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
	/// Structure <code>RCEmployeeRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEmployeeRecord: ISerializable, ITypedRecord<RCEmployeeRecord> {
		internal static readonly GlobalObjectKey IdEmployee = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3PKEpltFVYkD9QV6TuIfnA");

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

	/// <summary>
	/// Structure <code>RCEmployeePhotoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEmployeePhotoRecord: ISerializable, ITypedRecord<RCEmployeePhotoRecord> {
		internal static readonly GlobalObjectKey IdEmployeePhoto = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tsPRBDIgjcc3415bn2ItMA");

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
	/// Structure <code>RCPayrollRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCPayrollRecord: ISerializable, ITypedRecord<RCPayrollRecord> {
		internal static readonly GlobalObjectKey IdPayroll = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SdwstPdipfC4oVLS3IWDoQ");

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
	/// Structure <code>RCTimeSheetRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTimeSheetRecord: ISerializable, ITypedRecord<RCTimeSheetRecord> {
		internal static readonly GlobalObjectKey IdTimeSheet = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kMZFhHX+IjM+6wxG2Yspmg");

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
	/// Structure <code>RCFaQRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCFaQRecord: ISerializable, ITypedRecord<RCFaQRecord> {
		internal static readonly GlobalObjectKey IdFaQ = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lv9S4J3KQN7ms7bk6oqQIA");

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
	/// Structure <code>RCNewsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCNewsRecord: ISerializable, ITypedRecord<RCNewsRecord> {
		internal static readonly GlobalObjectKey IdNews = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1I_USXQnIPTNF0__HeLfhg");

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
}
