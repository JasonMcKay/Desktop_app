﻿/*
    Author: Ijaaz Lagardien
    Student Number: 214167542
    File: DailySpecials.cs
    Subject: Technical Programming 2
*/
using System;
using System.Runtime.Serialization;

namespace DesktopApp.main.domain.specials
{
    [Serializable]
    public class DailySpecial :ISerializable
    {
        private String name, price, dayOfSpecial;

        public DailySpecial() { }

        public DailySpecial(String name, String price, String dayOfSpecial)
        {
            this.name = name;
            this.price = price;
            this.dayOfSpecial = dayOfSpecial;
        }

        public string DayOfSpecial
        {
            get
            {
                return dayOfSpecial;
            }

            set
            {
                dayOfSpecial = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
