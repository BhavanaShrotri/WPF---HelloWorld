﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPFProject.Model
{
    public class HelloWorldModel
    {
        private List<string> repositoryData;

        public HelloWorldModel()
        {
            repositoryData = GetData();
        }

        private List<string> GetData()
        {
            repositoryData = new List<string>()
            {
                "Hello",
                "world"
            };
            return repositoryData;
        }

        public string ImportantInfo
        {
            get
            {
                return ConcatenateData(repositoryData);
            }
        }

        private string ConcatenateData(List<string> dataList)
        {
            string importantInfo = dataList.ElementAt(0) + ", " + dataList.ElementAt(1) + "!";
            return importantInfo;
        }
    }
}
