﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace votes
{
    class Connect
    {
        public static string GetConnectionString()
        {
            //return @"provider=Microsoft.ACE.OLEDB.12.0; Data source=C:\Users\laptop\Desktop\תשעט\RamonDrivingSchool\DrivingDAL\App_Data\AtMaDb11.accdb";
            return @"provider =Microsoft.ACE.OLEDB.12.0; Data source=Y:\תשפ\הנדסת תכנה כיתה יב\תלמידים\┬┴┬┴┤  (⌐■├┬┴┬┴\DAL\DAL\AppData\Elections.accdb";
            //  return @"provider=Microsoft.ACE.OLEDB.12.0; Data source=C:\Users\laptop\Desktop\תשעט\Driving2018_2019\Driving2018_2019\RamonDrivingSchool\DrivingDAL\App_Data\AtMaDb11.accdb";
            //  return @"provider =Microsoft.ACE.OLEDB.12.0; Data source=..\..\App_Data\AtMaDb11.accdb";
            //********* string connString = @"Provider =Microsoft.Jet.OLEDB.4.0;data source=" + path;  //mdb  עבור סיומת
            //********* string connString = @"provider=Microsoft.ACE.OLEDB.12.0; Data source=" + path;  // accdb עבור סיומת
        }
    }
}
