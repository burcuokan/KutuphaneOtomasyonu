﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    class sqlbaglantisi  
    {
        public SqlConnection baglanti() 
        {
            SqlConnection baglan = new SqlConnection("Data Source=OKAN;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True"); 
            baglan.Open();
            return baglan; 
        }
    }
}