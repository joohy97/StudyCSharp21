﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookApp
{
    class datafilemanager
    {
        //주소록 파일 불러오기
        string dataFileName = "address.dat";
        //Console.WriteLine(Environment.CurrentDirectory);
        //D:\GitRepository\StudyCSharp21\chap99\AddressBookApp\bin\Debug\netcoreapp3.1


        public void ReadData(List<AddressInfo> param)
        {
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName;
            StreamReader sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                string[] splits = temp.Split("|");
                param.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();
        }

        public void WriteData(List<AddressInfo> param)
        {
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName;
            //주소록 파일 쓰기
            StreamWriter sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
            if (param.Count > 0)
            {
                foreach (var item in param)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            }
            sw.Close();
        }
    }
}
