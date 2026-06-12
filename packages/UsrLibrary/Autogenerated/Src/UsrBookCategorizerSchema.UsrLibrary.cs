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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,141,49,14,130,64,16,69,123,18,238,48,21,209,134,96,97,97,16,11,169,76,44,241,0,203,186,192,198,117,135,204,44,5,26,238,238,34,36,144,240,155,249,197,123,243,173,120,43,110,133,84,80,40,34,193,88,185,56,71,91,233,186,35,225,52,218,248,193,116,215,37,9,234,195,224,27,6,224,211,118,165,209,18,216,121,66,130,52,130,25,60,118,69,124,229,194,169,26,73,127,20,77,236,172,172,52,137,150,29,104,235,32,31,77,45,139,134,20,55,104,158,144,193,225,116,76,210,48,216,72,243,86,137,104,224,198,179,184,27,159,244,74,208,126,225,87,123,99,72,185,142,236,31,130,11,36,16,69,83,63,103,155,245,116,49,135,169,250,51,252,0,33,16,237,143,33,1,0,0 };
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

