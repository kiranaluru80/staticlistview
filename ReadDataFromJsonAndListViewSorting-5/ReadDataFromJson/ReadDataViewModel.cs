using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace ReadDataFromJson
{
	public class ReadDataViewModel : ViewModelBase
	{

		public List<JSSEData> OrgRelatedData => orgRelatedData;

		List<JSSEData> orgRelatedData = new List<JSSEData>();
		List<SearchOrgUsersResult> SroringData = new List<SearchOrgUsersResult>();


		//Picker related Data start
		public class PickerData
		{
			public string Name { get; set; }
			public string Id { get; set; }
		}

		public class JSSEData
		{
			public int jsseId { get; set; }
			public string jsseDate { get; set; }
            public string status { get; set; }
		}

		public List<PickerData> RootObjectSe => rootObjectSe;
		List<PickerData> rootObjectSe = new List<PickerData>();

		PickerData selectedMajorGroup;
		public PickerData SelectedMajorGroup
		{
			get { return selectedMajorGroup; }
			set
			{
				if (selectedMajorGroup != value)
				{
					selectedMajorGroup = value;
					OnPropertyChanged();
					OnPropertyChanged("SelectedMajorGroup");
				}
			}
		}
		//Picker related data end

		//public void textChangedMethod(string searchBarText)
		//{
		//	//orgRelatedData = orgRelatedData.OrderBy(x => x.FirstName).ToList();
		//	if (searchBarText == null || searchBarText == "")
		//	{
		//		Debug.WriteLine("Cancel Pressed");
		//		orgRelatedData = SroringData;
		//	}

		//	else if (searchBarText.Length > 0)
		//	{
		//		orgRelatedData = SroringData.Where(x => x.FirstName.Contains(searchBarText)).ToList();
		//	}

		//	OnPropertyChanged("OrgRelatedData");
		//}


		public ReadDataViewModel()
		{
			var assembly = typeof(ReadDataViewModel).GetTypeInfo().Assembly;
			Stream stream = assembly.GetManifestResourceStream("ReadDataFromJson.getbannerdata.json");


			PickerData obj = new PickerData();
			obj.Name = "Bharath";
			obj.Id = "702";

			PickerData objTwo = new PickerData();
			objTwo.Name = "subbu";
			objTwo.Id = "802";

			rootObjectSe.Add(obj);
			rootObjectSe.Add(objTwo);



            JSSEData jsseOne = new JSSEData();
            jsseOne.jsseId = 35;
            jsseOne.jsseDate = "08/03/2017";
            jsseOne.status = "Submitted";


			JSSEData jsseTwo = new JSSEData();
			jsseTwo.jsseId = 52;
			jsseTwo.jsseDate = "08/09/2017";
			jsseTwo.status = "Submitted";

			JSSEData jsseThree = new JSSEData();
			jsseThree.jsseId = 68;
			jsseThree.jsseDate = "08/15/2017";
			jsseThree.status = "Draft";

			JSSEData jsseFour = new JSSEData();
			jsseFour.jsseId = 73;
			jsseFour.jsseDate = "08/23/2017";
			jsseFour.status = "Draft";

            orgRelatedData.Add(jsseOne);
            orgRelatedData.Add(jsseTwo);
            orgRelatedData.Add(jsseThree);
            orgRelatedData.Add(jsseThree);

			//using (var reader = new System.IO.StreamReader(stream))
			//{

			//	var json = reader.ReadToEnd();
			//	RootObjectNew data = JsonConvert.DeserializeObject<RootObjectNew>(json);

			//	for (int i = 0; i < data.SearchOrgUsersResult.Count; i++)
			//	{
			//		SearchOrgUsersResult dataObject = data.SearchOrgUsersResult[i];
			//		Debug.WriteLine("First Major ID :" + i + "= " + dataObject.FirstName);
			//		Debug.WriteLine("First Major Name :" + i + "= " + dataObject.LastName);
			//		orgRelatedData.Add(dataObject);
			//	}
			//	SroringData = orgRelatedData;
			//}



		}


	}
}
