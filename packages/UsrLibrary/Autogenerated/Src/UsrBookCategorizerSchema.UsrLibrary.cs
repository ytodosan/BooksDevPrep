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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,177,78,195,64,12,134,247,72,121,7,79,85,187,84,233,208,1,5,144,32,83,165,142,229,1,46,135,211,90,28,231,202,118,134,130,242,238,92,104,164,38,20,68,189,156,173,251,62,255,142,238,29,245,232,60,194,14,69,156,114,99,203,138,99,67,251,86,156,17,199,229,139,202,150,106,113,114,202,179,207,60,131,84,199,182,14,228,65,45,17,30,124,112,170,144,176,103,230,183,202,25,238,89,232,3,229,204,14,202,72,243,28,213,128,162,65,213,155,228,119,7,65,61,112,120,133,7,88,221,173,139,50,207,174,164,33,171,102,14,176,209,65,156,247,75,78,232,100,113,225,71,121,125,9,90,43,241,27,130,71,40,96,54,59,247,247,87,225,229,69,236,254,61,224,41,122,194,104,55,28,64,13,204,127,73,95,173,139,98,49,37,127,136,163,235,77,90,44,167,191,221,116,196,160,120,235,182,198,37,248,239,117,67,155,158,238,11,171,27,84,51,29,2,0,0 };
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

