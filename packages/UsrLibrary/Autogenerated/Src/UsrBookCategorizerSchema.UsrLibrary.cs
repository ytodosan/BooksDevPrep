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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,49,79,195,64,12,133,247,72,249,15,158,170,118,105,211,161,3,74,83,9,50,33,49,161,194,238,28,78,106,17,238,34,251,50,20,212,255,206,93,73,212,162,128,192,203,221,240,62,191,247,100,139,111,164,29,26,130,61,137,160,186,218,47,75,103,107,110,122,65,207,206,46,159,84,30,184,18,148,99,154,172,86,208,9,117,32,228,133,155,134,36,77,62,210,4,194,116,125,213,178,1,245,1,50,96,90,84,133,64,222,57,247,90,162,167,198,9,191,71,121,212,14,200,21,102,156,85,15,108,61,148,145,100,179,63,8,233,193,181,47,80,192,250,102,147,229,105,50,129,6,175,202,185,22,238,117,0,231,113,201,145,80,22,23,253,149,95,156,16,190,23,123,22,193,14,50,152,205,190,254,219,137,121,126,1,79,127,6,184,181,134,201,250,127,4,56,3,172,207,216,114,236,55,31,147,44,160,40,192,75,79,249,15,250,138,106,39,244,72,22,89,21,109,56,216,72,110,97,189,201,126,133,135,182,163,93,40,59,217,244,189,230,240,156,62,1,222,59,16,78,26,2,0,0 };
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

