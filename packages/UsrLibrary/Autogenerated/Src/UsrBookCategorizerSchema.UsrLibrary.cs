namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrBookCategorizerSchema

	/// <exclude/>
	public class UsrBookCategorizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrBookCategorizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrBookCategorizerSchema(UsrBookCategorizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9915247c-0113-4bd1-a74c-31cafeee722a");
			Name = "UsrBookCategorizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("418f4cdc-554b-4c69-8787-5860d134957c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,142,189,10,194,80,12,70,247,66,223,33,147,232,162,117,232,32,254,128,118,18,28,245,1,110,175,177,6,235,77,73,110,7,21,223,221,94,45,84,113,112,48,75,50,156,147,239,115,230,140,90,25,139,176,69,17,163,124,240,195,140,221,129,138,90,140,39,118,195,157,202,134,114,49,114,137,163,209,8,42,193,10,4,189,80,81,160,196,209,45,142,160,153,170,206,75,178,160,190,145,44,216,210,168,66,99,174,152,79,153,241,88,176,208,53,224,129,109,149,55,205,178,83,15,228,60,100,193,36,187,61,10,234,145,203,61,204,97,60,73,147,105,28,125,73,109,86,206,92,194,90,91,177,31,158,92,208,200,160,227,223,242,194,52,229,107,113,79,8,22,144,64,175,247,186,103,95,225,211,78,188,255,44,176,116,150,208,249,191,10,140,211,36,249,12,109,215,253,1,234,218,164,160,168,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9915247c-0113-4bd1-a74c-31cafeee722a"));
		}

		#endregion

	}

	#endregion

}

