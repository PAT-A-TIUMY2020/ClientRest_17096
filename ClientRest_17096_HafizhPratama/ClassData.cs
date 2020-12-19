﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Net;

namespace ClientRest_17096_HafizhPratama
{
	class ClassData
	{
		public void getData()
		{
			var json = new WebClient().DownloadString("http://localhost:1112/Mahasiswa");
			var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

			foreach (var mhs in data)
			{
				Console.WriteLine("NAMA: " + mhs.nama);
				Console.WriteLine("NIM: " + mhs.nim);
				Console.WriteLine("Prodi: " + mhs.prodi);
				Console.WriteLine("Angkatan: " + mhs.angkatan);
			}
			Console.ReadLine();
		}
	}
}
