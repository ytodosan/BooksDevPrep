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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,141,49,14,130,64,16,69,123,18,238,48,21,209,198,96,97,97,80,11,169,76,44,241,0,203,58,192,70,220,33,51,75,129,134,187,187,8,9,36,252,102,126,241,222,124,171,222,40,141,210,8,25,50,43,161,194,237,82,178,133,41,91,86,206,144,221,61,132,239,38,103,197,93,24,124,195,0,124,154,54,175,141,6,113,158,208,160,107,37,2,30,187,18,189,82,229,176,36,54,31,228,145,157,148,133,166,201,138,3,99,29,164,131,105,116,86,49,74,69,245,19,206,176,63,30,226,36,12,86,210,180,149,19,213,112,147,73,220,12,79,58,84,188,157,249,197,222,16,70,215,178,253,67,112,129,24,162,104,236,167,213,120,50,139,253,88,253,233,127,37,216,234,38,32,1,0,0 };
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

