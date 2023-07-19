using System;
using System.Collections;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssExtensionAzure {

	/// <summary>
	/// Structure <code>RCEmployeePhotoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEmployeePhotoRecord: ISerializable, ITypedRecord<RCEmployeePhotoRecord> {
		internal static readonly GlobalObjectKey IdEmployeePhoto = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DTI2ovmDFqREEr4dXXrZ7g");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EmployeePhoto")]
		public ENEmployeePhotoEntityRecord ssENEmployeePhoto;


		public static implicit operator ENEmployeePhotoEntityRecord(RCEmployeePhotoRecord r) {
			return r.ssENEmployeePhoto;
		}

		public static implicit operator RCEmployeePhotoRecord(ENEmployeePhotoEntityRecord r) {
			RCEmployeePhotoRecord res = new RCEmployeePhotoRecord(null);
			res.ssENEmployeePhoto = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENEmployeePhoto.ChangedAttributes = value;
			}
			get {
				return ssENEmployeePhoto.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCEmployeePhotoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENEmployeePhoto = new ENEmployeePhotoEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(8, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENEmployeePhoto.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENEmployeePhoto.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENEmployeePhoto.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENEmployeePhoto.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEmployeePhotoRecord r) {
			this = r;
		}


		public static bool operator == (RCEmployeePhotoRecord a, RCEmployeePhotoRecord b) {
			if (a.ssENEmployeePhoto != b.ssENEmployeePhoto) return false;
			return true;
		}

		public static bool operator != (RCEmployeePhotoRecord a, RCEmployeePhotoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEmployeePhotoRecord)) return false;
			return (this == (RCEmployeePhotoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENEmployeePhoto.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEmployeePhotoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENEmployeePhoto = new ENEmployeePhotoEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENEmployeePhoto", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENEmployeePhoto' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENEmployeePhoto = (ENEmployeePhotoEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENEmployeePhoto.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENEmployeePhoto.InternalRecursiveSave();
		}


		public RCEmployeePhotoRecord Duplicate() {
			RCEmployeePhotoRecord t;
			t.ssENEmployeePhoto = (ENEmployeePhotoEntityRecord) this.ssENEmployeePhoto.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENEmployeePhoto.ToXml(this, recordElem, "EmployeePhoto", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "employeephoto") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EmployeePhoto")) variable.Value = ssENEmployeePhoto; else variable.Optimized = true;
				variable.SetFieldName("employeephoto");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENEmployeePhoto.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENEmployeePhoto.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEmployeePhoto) {
				return ssENEmployeePhoto;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENEmployeePhoto.FillFromOther((IRecord) other.AttributeGet(IdEmployeePhoto));
		}
		public bool IsDefault() {
			RCEmployeePhotoRecord defaultStruct = new RCEmployeePhotoRecord(null);
			if (this.ssENEmployeePhoto != defaultStruct.ssENEmployeePhoto) return false;
			return true;
		}
	} // RCEmployeePhotoRecord

	/// <summary>
	/// Structure <code>RCDepartmentRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDepartmentRecord: ISerializable, ITypedRecord<RCDepartmentRecord> {
		internal static readonly GlobalObjectKey IdDepartment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ghR3qg2hTYO8dYzT7Ob8Yg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Department")]
		public ENDepartmentEntityRecord ssENDepartment;


		public static implicit operator ENDepartmentEntityRecord(RCDepartmentRecord r) {
			return r.ssENDepartment;
		}

		public static implicit operator RCDepartmentRecord(ENDepartmentEntityRecord r) {
			RCDepartmentRecord res = new RCDepartmentRecord(null);
			res.ssENDepartment = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENDepartment.ChangedAttributes = value;
			}
			get {
				return ssENDepartment.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCDepartmentRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENDepartment = new ENDepartmentEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(3, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENDepartment.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENDepartment.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENDepartment.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENDepartment.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDepartmentRecord r) {
			this = r;
		}


		public static bool operator == (RCDepartmentRecord a, RCDepartmentRecord b) {
			if (a.ssENDepartment != b.ssENDepartment) return false;
			return true;
		}

		public static bool operator != (RCDepartmentRecord a, RCDepartmentRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDepartmentRecord)) return false;
			return (this == (RCDepartmentRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENDepartment.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDepartmentRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENDepartment = new ENDepartmentEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENDepartment", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENDepartment' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENDepartment = (ENDepartmentEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENDepartment.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENDepartment.InternalRecursiveSave();
		}


		public RCDepartmentRecord Duplicate() {
			RCDepartmentRecord t;
			t.ssENDepartment = (ENDepartmentEntityRecord) this.ssENDepartment.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENDepartment.ToXml(this, recordElem, "Department", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "department") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Department")) variable.Value = ssENDepartment; else variable.Optimized = true;
				variable.SetFieldName("department");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENDepartment.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENDepartment.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDepartment) {
				return ssENDepartment;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENDepartment.FillFromOther((IRecord) other.AttributeGet(IdDepartment));
		}
		public bool IsDefault() {
			RCDepartmentRecord defaultStruct = new RCDepartmentRecord(null);
			if (this.ssENDepartment != defaultStruct.ssENDepartment) return false;
			return true;
		}
	} // RCDepartmentRecord

	/// <summary>
	/// Structure <code>RCBranchRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCBranchRecord: ISerializable, ITypedRecord<RCBranchRecord> {
		internal static readonly GlobalObjectKey IdBranch = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OfOQaODz2iEo95lJdnk9Zw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Branch")]
		public ENBranchEntityRecord ssENBranch;


		public static implicit operator ENBranchEntityRecord(RCBranchRecord r) {
			return r.ssENBranch;
		}

		public static implicit operator RCBranchRecord(ENBranchEntityRecord r) {
			RCBranchRecord res = new RCBranchRecord(null);
			res.ssENBranch = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENBranch.ChangedAttributes = value;
			}
			get {
				return ssENBranch.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCBranchRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENBranch = new ENBranchEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(3, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENBranch.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENBranch.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENBranch.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENBranch.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCBranchRecord r) {
			this = r;
		}


		public static bool operator == (RCBranchRecord a, RCBranchRecord b) {
			if (a.ssENBranch != b.ssENBranch) return false;
			return true;
		}

		public static bool operator != (RCBranchRecord a, RCBranchRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCBranchRecord)) return false;
			return (this == (RCBranchRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENBranch.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCBranchRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENBranch = new ENBranchEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENBranch", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENBranch' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENBranch = (ENBranchEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENBranch.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENBranch.InternalRecursiveSave();
		}


		public RCBranchRecord Duplicate() {
			RCBranchRecord t;
			t.ssENBranch = (ENBranchEntityRecord) this.ssENBranch.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENBranch.ToXml(this, recordElem, "Branch", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "branch") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Branch")) variable.Value = ssENBranch; else variable.Optimized = true;
				variable.SetFieldName("branch");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENBranch.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENBranch.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdBranch) {
				return ssENBranch;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENBranch.FillFromOther((IRecord) other.AttributeGet(IdBranch));
		}
		public bool IsDefault() {
			RCBranchRecord defaultStruct = new RCBranchRecord(null);
			if (this.ssENBranch != defaultStruct.ssENBranch) return false;
			return true;
		}
	} // RCBranchRecord

	/// <summary>
	/// Structure <code>RCPayrollRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCPayrollRecord: ISerializable, ITypedRecord<RCPayrollRecord> {
		internal static readonly GlobalObjectKey IdPayroll = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RR8o6WppUdsQ4T1F40y6Pg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Payroll")]
		public ENPayrollEntityRecord ssENPayroll;


		public static implicit operator ENPayrollEntityRecord(RCPayrollRecord r) {
			return r.ssENPayroll;
		}

		public static implicit operator RCPayrollRecord(ENPayrollEntityRecord r) {
			RCPayrollRecord res = new RCPayrollRecord(null);
			res.ssENPayroll = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENPayroll.ChangedAttributes = value;
			}
			get {
				return ssENPayroll.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCPayrollRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENPayroll = new ENPayrollEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(8, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENPayroll.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENPayroll.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENPayroll.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENPayroll.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCPayrollRecord r) {
			this = r;
		}


		public static bool operator == (RCPayrollRecord a, RCPayrollRecord b) {
			if (a.ssENPayroll != b.ssENPayroll) return false;
			return true;
		}

		public static bool operator != (RCPayrollRecord a, RCPayrollRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCPayrollRecord)) return false;
			return (this == (RCPayrollRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENPayroll.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCPayrollRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENPayroll = new ENPayrollEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENPayroll", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENPayroll' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENPayroll = (ENPayrollEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENPayroll.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENPayroll.InternalRecursiveSave();
		}


		public RCPayrollRecord Duplicate() {
			RCPayrollRecord t;
			t.ssENPayroll = (ENPayrollEntityRecord) this.ssENPayroll.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENPayroll.ToXml(this, recordElem, "Payroll", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "payroll") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Payroll")) variable.Value = ssENPayroll; else variable.Optimized = true;
				variable.SetFieldName("payroll");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENPayroll.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENPayroll.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdPayroll) {
				return ssENPayroll;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENPayroll.FillFromOther((IRecord) other.AttributeGet(IdPayroll));
		}
		public bool IsDefault() {
			RCPayrollRecord defaultStruct = new RCPayrollRecord(null);
			if (this.ssENPayroll != defaultStruct.ssENPayroll) return false;
			return true;
		}
	} // RCPayrollRecord

	/// <summary>
	/// Structure <code>RCNewsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCNewsRecord: ISerializable, ITypedRecord<RCNewsRecord> {
		internal static readonly GlobalObjectKey IdNews = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HIexNJHfGEbixqeUGegeuw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("News")]
		public ENNewsEntityRecord ssENNews;


		public static implicit operator ENNewsEntityRecord(RCNewsRecord r) {
			return r.ssENNews;
		}

		public static implicit operator RCNewsRecord(ENNewsEntityRecord r) {
			RCNewsRecord res = new RCNewsRecord(null);
			res.ssENNews = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENNews.ChangedAttributes = value;
			}
			get {
				return ssENNews.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCNewsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENNews = new ENNewsEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(10, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENNews.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENNews.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENNews.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENNews.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCNewsRecord r) {
			this = r;
		}


		public static bool operator == (RCNewsRecord a, RCNewsRecord b) {
			if (a.ssENNews != b.ssENNews) return false;
			return true;
		}

		public static bool operator != (RCNewsRecord a, RCNewsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCNewsRecord)) return false;
			return (this == (RCNewsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENNews.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCNewsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENNews = new ENNewsEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENNews", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENNews' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENNews = (ENNewsEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENNews.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENNews.InternalRecursiveSave();
		}


		public RCNewsRecord Duplicate() {
			RCNewsRecord t;
			t.ssENNews = (ENNewsEntityRecord) this.ssENNews.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENNews.ToXml(this, recordElem, "News", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "news") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".News")) variable.Value = ssENNews; else variable.Optimized = true;
				variable.SetFieldName("news");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENNews.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENNews.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdNews) {
				return ssENNews;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENNews.FillFromOther((IRecord) other.AttributeGet(IdNews));
		}
		public bool IsDefault() {
			RCNewsRecord defaultStruct = new RCNewsRecord(null);
			if (this.ssENNews != defaultStruct.ssENNews) return false;
			return true;
		}
	} // RCNewsRecord

	/// <summary>
	/// Structure <code>RCTimeSheetPDFRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTimeSheetPDFRecord: ISerializable, ITypedRecord<RCTimeSheetPDFRecord> {
		internal static readonly GlobalObjectKey IdTimeSheetPDF = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Xl3m27i1yTDz7odsMfGkfQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("TimeSheetPDF")]
		public ENTimeSheetPDFEntityRecord ssENTimeSheetPDF;


		public static implicit operator ENTimeSheetPDFEntityRecord(RCTimeSheetPDFRecord r) {
			return r.ssENTimeSheetPDF;
		}

		public static implicit operator RCTimeSheetPDFRecord(ENTimeSheetPDFEntityRecord r) {
			RCTimeSheetPDFRecord res = new RCTimeSheetPDFRecord(null);
			res.ssENTimeSheetPDF = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENTimeSheetPDF.ChangedAttributes = value;
			}
			get {
				return ssENTimeSheetPDF.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCTimeSheetPDFRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENTimeSheetPDF = new ENTimeSheetPDFEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(8, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENTimeSheetPDF.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENTimeSheetPDF.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENTimeSheetPDF.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENTimeSheetPDF.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCTimeSheetPDFRecord r) {
			this = r;
		}


		public static bool operator == (RCTimeSheetPDFRecord a, RCTimeSheetPDFRecord b) {
			if (a.ssENTimeSheetPDF != b.ssENTimeSheetPDF) return false;
			return true;
		}

		public static bool operator != (RCTimeSheetPDFRecord a, RCTimeSheetPDFRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTimeSheetPDFRecord)) return false;
			return (this == (RCTimeSheetPDFRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENTimeSheetPDF.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCTimeSheetPDFRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENTimeSheetPDF = new ENTimeSheetPDFEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENTimeSheetPDF", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENTimeSheetPDF' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENTimeSheetPDF = (ENTimeSheetPDFEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENTimeSheetPDF.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENTimeSheetPDF.InternalRecursiveSave();
		}


		public RCTimeSheetPDFRecord Duplicate() {
			RCTimeSheetPDFRecord t;
			t.ssENTimeSheetPDF = (ENTimeSheetPDFEntityRecord) this.ssENTimeSheetPDF.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENTimeSheetPDF.ToXml(this, recordElem, "TimeSheetPDF", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "timesheetpdf") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TimeSheetPDF")) variable.Value = ssENTimeSheetPDF; else variable.Optimized = true;
				variable.SetFieldName("timesheetpdf");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENTimeSheetPDF.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENTimeSheetPDF.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdTimeSheetPDF) {
				return ssENTimeSheetPDF;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENTimeSheetPDF.FillFromOther((IRecord) other.AttributeGet(IdTimeSheetPDF));
		}
		public bool IsDefault() {
			RCTimeSheetPDFRecord defaultStruct = new RCTimeSheetPDFRecord(null);
			if (this.ssENTimeSheetPDF != defaultStruct.ssENTimeSheetPDF) return false;
			return true;
		}
	} // RCTimeSheetPDFRecord

	/// <summary>
	/// Structure <code>RCPayrollPDFRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCPayrollPDFRecord: ISerializable, ITypedRecord<RCPayrollPDFRecord> {
		internal static readonly GlobalObjectKey IdPayrollPDF = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*A_PcBc1qT5DzsomsGtR_2Q");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("PayrollPDF")]
		public ENPayrollPDFEntityRecord ssENPayrollPDF;


		public static implicit operator ENPayrollPDFEntityRecord(RCPayrollPDFRecord r) {
			return r.ssENPayrollPDF;
		}

		public static implicit operator RCPayrollPDFRecord(ENPayrollPDFEntityRecord r) {
			RCPayrollPDFRecord res = new RCPayrollPDFRecord(null);
			res.ssENPayrollPDF = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENPayrollPDF.ChangedAttributes = value;
			}
			get {
				return ssENPayrollPDF.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCPayrollPDFRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENPayrollPDF = new ENPayrollPDFEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(8, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENPayrollPDF.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENPayrollPDF.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENPayrollPDF.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENPayrollPDF.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCPayrollPDFRecord r) {
			this = r;
		}


		public static bool operator == (RCPayrollPDFRecord a, RCPayrollPDFRecord b) {
			if (a.ssENPayrollPDF != b.ssENPayrollPDF) return false;
			return true;
		}

		public static bool operator != (RCPayrollPDFRecord a, RCPayrollPDFRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCPayrollPDFRecord)) return false;
			return (this == (RCPayrollPDFRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENPayrollPDF.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCPayrollPDFRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENPayrollPDF = new ENPayrollPDFEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENPayrollPDF", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENPayrollPDF' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENPayrollPDF = (ENPayrollPDFEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENPayrollPDF.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENPayrollPDF.InternalRecursiveSave();
		}


		public RCPayrollPDFRecord Duplicate() {
			RCPayrollPDFRecord t;
			t.ssENPayrollPDF = (ENPayrollPDFEntityRecord) this.ssENPayrollPDF.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENPayrollPDF.ToXml(this, recordElem, "PayrollPDF", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "payrollpdf") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".PayrollPDF")) variable.Value = ssENPayrollPDF; else variable.Optimized = true;
				variable.SetFieldName("payrollpdf");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENPayrollPDF.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENPayrollPDF.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdPayrollPDF) {
				return ssENPayrollPDF;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENPayrollPDF.FillFromOther((IRecord) other.AttributeGet(IdPayrollPDF));
		}
		public bool IsDefault() {
			RCPayrollPDFRecord defaultStruct = new RCPayrollPDFRecord(null);
			if (this.ssENPayrollPDF != defaultStruct.ssENPayrollPDF) return false;
			return true;
		}
	} // RCPayrollPDFRecord

	/// <summary>
	/// Structure <code>RCTimeSheetRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTimeSheetRecord: ISerializable, ITypedRecord<RCTimeSheetRecord> {
		internal static readonly GlobalObjectKey IdTimeSheet = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lcUhDPdJWKPs84o8aTwNnQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("TimeSheet")]
		public ENTimeSheetEntityRecord ssENTimeSheet;


		public static implicit operator ENTimeSheetEntityRecord(RCTimeSheetRecord r) {
			return r.ssENTimeSheet;
		}

		public static implicit operator RCTimeSheetRecord(ENTimeSheetEntityRecord r) {
			RCTimeSheetRecord res = new RCTimeSheetRecord(null);
			res.ssENTimeSheet = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENTimeSheet.ChangedAttributes = value;
			}
			get {
				return ssENTimeSheet.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCTimeSheetRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENTimeSheet = new ENTimeSheetEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(8, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENTimeSheet.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENTimeSheet.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENTimeSheet.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENTimeSheet.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCTimeSheetRecord r) {
			this = r;
		}


		public static bool operator == (RCTimeSheetRecord a, RCTimeSheetRecord b) {
			if (a.ssENTimeSheet != b.ssENTimeSheet) return false;
			return true;
		}

		public static bool operator != (RCTimeSheetRecord a, RCTimeSheetRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTimeSheetRecord)) return false;
			return (this == (RCTimeSheetRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENTimeSheet.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCTimeSheetRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENTimeSheet = new ENTimeSheetEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENTimeSheet", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENTimeSheet' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENTimeSheet = (ENTimeSheetEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENTimeSheet.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENTimeSheet.InternalRecursiveSave();
		}


		public RCTimeSheetRecord Duplicate() {
			RCTimeSheetRecord t;
			t.ssENTimeSheet = (ENTimeSheetEntityRecord) this.ssENTimeSheet.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENTimeSheet.ToXml(this, recordElem, "TimeSheet", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "timesheet") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TimeSheet")) variable.Value = ssENTimeSheet; else variable.Optimized = true;
				variable.SetFieldName("timesheet");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENTimeSheet.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENTimeSheet.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdTimeSheet) {
				return ssENTimeSheet;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENTimeSheet.FillFromOther((IRecord) other.AttributeGet(IdTimeSheet));
		}
		public bool IsDefault() {
			RCTimeSheetRecord defaultStruct = new RCTimeSheetRecord(null);
			if (this.ssENTimeSheet != defaultStruct.ssENTimeSheet) return false;
			return true;
		}
	} // RCTimeSheetRecord

	/// <summary>
	/// Structure <code>RCJobTitleRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCJobTitleRecord: ISerializable, ITypedRecord<RCJobTitleRecord> {
		internal static readonly GlobalObjectKey IdJobTitle = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*n0pxF9t+nn4IjMaW1rvhCg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("JobTitle")]
		public ENJobTitleEntityRecord ssENJobTitle;


		public static implicit operator ENJobTitleEntityRecord(RCJobTitleRecord r) {
			return r.ssENJobTitle;
		}

		public static implicit operator RCJobTitleRecord(ENJobTitleEntityRecord r) {
			RCJobTitleRecord res = new RCJobTitleRecord(null);
			res.ssENJobTitle = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENJobTitle.ChangedAttributes = value;
			}
			get {
				return ssENJobTitle.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCJobTitleRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENJobTitle = new ENJobTitleEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(3, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENJobTitle.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENJobTitle.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENJobTitle.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENJobTitle.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCJobTitleRecord r) {
			this = r;
		}


		public static bool operator == (RCJobTitleRecord a, RCJobTitleRecord b) {
			if (a.ssENJobTitle != b.ssENJobTitle) return false;
			return true;
		}

		public static bool operator != (RCJobTitleRecord a, RCJobTitleRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCJobTitleRecord)) return false;
			return (this == (RCJobTitleRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENJobTitle.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCJobTitleRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENJobTitle = new ENJobTitleEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENJobTitle", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENJobTitle' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENJobTitle = (ENJobTitleEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENJobTitle.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENJobTitle.InternalRecursiveSave();
		}


		public RCJobTitleRecord Duplicate() {
			RCJobTitleRecord t;
			t.ssENJobTitle = (ENJobTitleEntityRecord) this.ssENJobTitle.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENJobTitle.ToXml(this, recordElem, "JobTitle", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "jobtitle") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".JobTitle")) variable.Value = ssENJobTitle; else variable.Optimized = true;
				variable.SetFieldName("jobtitle");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENJobTitle.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENJobTitle.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdJobTitle) {
				return ssENJobTitle;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENJobTitle.FillFromOther((IRecord) other.AttributeGet(IdJobTitle));
		}
		public bool IsDefault() {
			RCJobTitleRecord defaultStruct = new RCJobTitleRecord(null);
			if (this.ssENJobTitle != defaultStruct.ssENJobTitle) return false;
			return true;
		}
	} // RCJobTitleRecord

	/// <summary>
	/// Structure <code>RCFaQRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCFaQRecord: ISerializable, ITypedRecord<RCFaQRecord> {
		internal static readonly GlobalObjectKey IdFaQ = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XjqzKH1iZ6bDBpWYrg5UXg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("FaQ")]
		public ENFaQEntityRecord ssENFaQ;


		public static implicit operator ENFaQEntityRecord(RCFaQRecord r) {
			return r.ssENFaQ;
		}

		public static implicit operator RCFaQRecord(ENFaQEntityRecord r) {
			RCFaQRecord res = new RCFaQRecord(null);
			res.ssENFaQ = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENFaQ.ChangedAttributes = value;
			}
			get {
				return ssENFaQ.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCFaQRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENFaQ = new ENFaQEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(8, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENFaQ.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENFaQ.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENFaQ.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENFaQ.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCFaQRecord r) {
			this = r;
		}


		public static bool operator == (RCFaQRecord a, RCFaQRecord b) {
			if (a.ssENFaQ != b.ssENFaQ) return false;
			return true;
		}

		public static bool operator != (RCFaQRecord a, RCFaQRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCFaQRecord)) return false;
			return (this == (RCFaQRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENFaQ.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCFaQRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENFaQ = new ENFaQEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENFaQ", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENFaQ' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENFaQ = (ENFaQEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENFaQ.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENFaQ.InternalRecursiveSave();
		}


		public RCFaQRecord Duplicate() {
			RCFaQRecord t;
			t.ssENFaQ = (ENFaQEntityRecord) this.ssENFaQ.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENFaQ.ToXml(this, recordElem, "FaQ", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "faq") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".FaQ")) variable.Value = ssENFaQ; else variable.Optimized = true;
				variable.SetFieldName("faq");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENFaQ.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENFaQ.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdFaQ) {
				return ssENFaQ;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENFaQ.FillFromOther((IRecord) other.AttributeGet(IdFaQ));
		}
		public bool IsDefault() {
			RCFaQRecord defaultStruct = new RCFaQRecord(null);
			if (this.ssENFaQ != defaultStruct.ssENFaQ) return false;
			return true;
		}
	} // RCFaQRecord

	/// <summary>
	/// Structure <code>RCEmployeeRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEmployeeRecord: ISerializable, ITypedRecord<RCEmployeeRecord> {
		internal static readonly GlobalObjectKey IdEmployee = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*peM2tpLd3vOjT+jZB5J1hw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Employee")]
		public ENEmployeeEntityRecord ssENEmployee;


		public static implicit operator ENEmployeeEntityRecord(RCEmployeeRecord r) {
			return r.ssENEmployee;
		}

		public static implicit operator RCEmployeeRecord(ENEmployeeEntityRecord r) {
			RCEmployeeRecord res = new RCEmployeeRecord(null);
			res.ssENEmployee = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENEmployee.ChangedAttributes = value;
			}
			get {
				return ssENEmployee.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCEmployeeRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENEmployee = new ENEmployeeEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(18, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENEmployee.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENEmployee.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENEmployee.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENEmployee.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEmployeeRecord r) {
			this = r;
		}


		public static bool operator == (RCEmployeeRecord a, RCEmployeeRecord b) {
			if (a.ssENEmployee != b.ssENEmployee) return false;
			return true;
		}

		public static bool operator != (RCEmployeeRecord a, RCEmployeeRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEmployeeRecord)) return false;
			return (this == (RCEmployeeRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENEmployee.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEmployeeRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENEmployee = new ENEmployeeEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENEmployee", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENEmployee' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENEmployee = (ENEmployeeEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENEmployee.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENEmployee.InternalRecursiveSave();
		}


		public RCEmployeeRecord Duplicate() {
			RCEmployeeRecord t;
			t.ssENEmployee = (ENEmployeeEntityRecord) this.ssENEmployee.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENEmployee.ToXml(this, recordElem, "Employee", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "employee") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Employee")) variable.Value = ssENEmployee; else variable.Optimized = true;
				variable.SetFieldName("employee");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENEmployee.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENEmployee.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEmployee) {
				return ssENEmployee;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENEmployee.FillFromOther((IRecord) other.AttributeGet(IdEmployee));
		}
		public bool IsDefault() {
			RCEmployeeRecord defaultStruct = new RCEmployeeRecord(null);
			if (this.ssENEmployee != defaultStruct.ssENEmployee) return false;
			return true;
		}
	} // RCEmployeeRecord
}
