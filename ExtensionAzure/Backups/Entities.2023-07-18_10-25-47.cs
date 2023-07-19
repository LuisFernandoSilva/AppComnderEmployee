using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssExtensionAzure {

	public class ENEmployeeEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "ef158d7b-f666-4ddd-8da2-8958459111da", "32e5ada4-7168-4f72-b92e-5238cd3aecf7", "Employee", "[Outsystems].[dbo].[Employee]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Outsystems].[dbo].[Employee]"; 
					}
				} catch {
					return "[Outsystems].[dbo].[Employee]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENEmployeeEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "username", "UserName"
			}
			, { "registration", "Registration"
			}
			, { "fullname", "FullName"
			}
			, { "jobtitle", "JobTitle"
			}
			, { "department", "Department"
			}
			, { "branch", "Branch"
			}
			, { "telephone", "TelePhone"
			}
			, { "zipcode", "ZipCode"
			}
			, { "street", "Street"
			}
			, { "neighborhood", "Neighborhood"
			}
			, { "city", "City"
			}
			, { "state", "State"
			}
			, { "isactive", "IsActive"
			}
			, { "updateon", "UpdateOn"
			}
			, { "createdon", "CreatedOn"
			}
			, { "createdby", "CreatedBy"
			}
			, { "updateby", "UpdateBy"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENEmployeeEntityConfiguration.GetPhysicalTableName();
		}
	} // ENEmployeeEntity

	/// <summary>
	/// Entity <code>ENEmployeeEntityRecord</code> that represents the Service Studio entity
	///  <code>Employee</code> <p> Description: Save the employees of the company and use that for login i
	/// n the sistem too</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Employee", "pK3lMmhxck+5LlI4zTrs9w", "e40V72b23U2NoolYRZER2g", 0, "[Outsystems].[dbo].[Employee]", null)]
	[Serializable()]
	public partial struct ENEmployeeEntityRecord: ISerializable, ITypedRecord<ENEmployeeEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*W07g0OX6dUynzsYQybuCmQ");
		internal static readonly GlobalObjectKey IdUserName = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*JJZy0LxdnEGwWHeodelN_A");
		internal static readonly GlobalObjectKey IdRegistration = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*QehupNFNMEW0DNCTmz+yZQ");
		internal static readonly GlobalObjectKey IdFullName = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*XQiIz9N_LUOFkkrUPdN7Lg");
		internal static readonly GlobalObjectKey IdJobTitle = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*56hZKV2RgEmrfvkgrIIAhQ");
		internal static readonly GlobalObjectKey IdDepartment = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*fIPg2Jwe80Sg_Htzb1GCHg");
		internal static readonly GlobalObjectKey IdBranch = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*R8g8WsQXykehL29cSeAM8Q");
		internal static readonly GlobalObjectKey IdTelePhone = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*GdjaaXQ+ukGrGBcyUM4n1w");
		internal static readonly GlobalObjectKey IdZipCode = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*o9B3DgLgRkyHrz9pAoOw1A");
		internal static readonly GlobalObjectKey IdStreet = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*yv0edZiAqEyAI8rxGh7P4A");
		internal static readonly GlobalObjectKey IdNeighborhood = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*LhToLsUOFUmzGe24BGRr0Q");
		internal static readonly GlobalObjectKey IdCity = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*Ob_YAtoCYU6QvIKQZTVOmg");
		internal static readonly GlobalObjectKey IdState = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*Ql2FMq3Ke0i1dn+D1nBP4g");
		internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*urj9_vxI2EOiFVpzYNlouA");
		internal static readonly GlobalObjectKey IdUpdateOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*EwAXDPf9dEO27RTdSIBtsg");
		internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*sfQTOs7sHkyEJ7_CLmFqAA");
		internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*jXHV_DcpsU+rf2S1wYeTSg");
		internal static readonly GlobalObjectKey IdUpdateBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*kCRD1MGi3EK5PMG5Ix0m+Q");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("id", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("id")]
		private int _ssid;
		public int ssid {
			get {
				return _ssid;
			}
			set {
				if ((_ssid!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(18, true);
					_ssid = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UserName", 150, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UserName")]
		private string _ssUserName;
		public string ssUserName {
			get {
				return _ssUserName;
			}
			set {
				if ((_ssUserName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssUserName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Registration", 250, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Registration")]
		private string _ssRegistration;
		public string ssRegistration {
			get {
				return _ssRegistration;
			}
			set {
				if ((_ssRegistration!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssRegistration = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("FullName", 150, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("FullName")]
		private string _ssFullName;
		public string ssFullName {
			get {
				return _ssFullName;
			}
			set {
				if ((_ssFullName!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssFullName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("JobTitle", 0, false, false, true, false)]
		[System.Xml.Serialization.XmlElement("JobTitle")]
		private int _ssJobTitle;
		public int ssJobTitle {
			get {
				return _ssJobTitle;
			}
			set {
				if ((_ssJobTitle!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssJobTitle = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Department", 0, false, false, true, false)]
		[System.Xml.Serialization.XmlElement("Department")]
		private int _ssDepartment;
		public int ssDepartment {
			get {
				return _ssDepartment;
			}
			set {
				if ((_ssDepartment!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssDepartment = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Branch", 0, false, false, true, false)]
		[System.Xml.Serialization.XmlElement("Branch")]
		private int _ssBranch;
		public int ssBranch {
			get {
				return _ssBranch;
			}
			set {
				if ((_ssBranch!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssBranch = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("TelePhone", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("TelePhone")]
		private string _ssTelePhone;
		public string ssTelePhone {
			get {
				return _ssTelePhone;
			}
			set {
				if ((_ssTelePhone!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssTelePhone = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ZipCode", 8, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("ZipCode")]
		private string _ssZipCode;
		public string ssZipCode {
			get {
				return _ssZipCode;
			}
			set {
				if ((_ssZipCode!=value) || OptimizedAttributes[8]) {
					ChangedAttributes[8] = true;
					_ssZipCode = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Street", 150, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Street")]
		private string _ssStreet;
		public string ssStreet {
			get {
				return _ssStreet;
			}
			set {
				if ((_ssStreet!=value) || OptimizedAttributes[9]) {
					ChangedAttributes[9] = true;
					_ssStreet = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Neighborhood", 150, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Neighborhood")]
		private string _ssNeighborhood;
		public string ssNeighborhood {
			get {
				return _ssNeighborhood;
			}
			set {
				if ((_ssNeighborhood!=value) || OptimizedAttributes[10]) {
					ChangedAttributes[10] = true;
					_ssNeighborhood = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("City", 50, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("City")]
		private string _ssCity;
		public string ssCity {
			get {
				return _ssCity;
			}
			set {
				if ((_ssCity!=value) || OptimizedAttributes[11]) {
					ChangedAttributes[11] = true;
					_ssCity = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("State", 50, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("State")]
		private string _ssState;
		public string ssState {
			get {
				return _ssState;
			}
			set {
				if ((_ssState!=value) || OptimizedAttributes[12]) {
					ChangedAttributes[12] = true;
					_ssState = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("IsActive", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("IsActive")]
		private bool _ssIsActive;
		public bool ssIsActive {
			get {
				return _ssIsActive;
			}
			set {
				if ((_ssIsActive!=value) || OptimizedAttributes[13]) {
					ChangedAttributes[13] = true;
					_ssIsActive = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateOn")]
		private DateTime _ssUpdateOn;
		public DateTime ssUpdateOn {
			get {
				return _ssUpdateOn;
			}
			set {
				if ((_ssUpdateOn!=value) || OptimizedAttributes[14]) {
					ChangedAttributes[14] = true;
					_ssUpdateOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedOn")]
		private DateTime _ssCreatedOn;
		public DateTime ssCreatedOn {
			get {
				return _ssCreatedOn;
			}
			set {
				if ((_ssCreatedOn!=value) || OptimizedAttributes[15]) {
					ChangedAttributes[15] = true;
					_ssCreatedOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedBy", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedBy")]
		private long _ssCreatedBy;
		public long ssCreatedBy {
			get {
				return _ssCreatedBy;
			}
			set {
				if ((_ssCreatedBy!=value) || OptimizedAttributes[16]) {
					ChangedAttributes[16] = true;
					_ssCreatedBy = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateBy", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateBy")]
		private long _ssUpdateBy;
		public long ssUpdateBy {
			get {
				return _ssUpdateBy;
			}
			set {
				if ((_ssUpdateBy!=value) || OptimizedAttributes[17]) {
					ChangedAttributes[17] = true;
					_ssUpdateBy = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENEmployeeEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(18, true);
			OptimizedAttributes = new BitArray(18, false);
			_ssid = 0;
			_ssUserName = "";
			_ssRegistration = "";
			_ssFullName = "";
			_ssJobTitle = 0;
			_ssDepartment = 0;
			_ssBranch = 0;
			_ssTelePhone = "";
			_ssZipCode = "";
			_ssStreet = "";
			_ssNeighborhood = "";
			_ssCity = "";
			_ssState = "";
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0L;
			_ssUpdateBy = 0L;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssid = r.ReadInteger(index++, "Employee.id", 0);
			ssUserName = r.ReadText(index++, "Employee.UserName", "");
			ssRegistration = r.ReadText(index++, "Employee.Registration", "");
			ssFullName = r.ReadText(index++, "Employee.FullName", "");
			ssJobTitle = r.ReadEntityReference(index++, "Employee.JobTitle", 0);
			ssDepartment = r.ReadEntityReference(index++, "Employee.Department", 0);
			ssBranch = r.ReadEntityReference(index++, "Employee.Branch", 0);
			ssTelePhone = r.ReadPhoneNumber(index++, "Employee.TelePhone", "");
			ssZipCode = r.ReadText(index++, "Employee.ZipCode", "");
			ssStreet = r.ReadText(index++, "Employee.Street", "");
			ssNeighborhood = r.ReadText(index++, "Employee.Neighborhood", "");
			ssCity = r.ReadText(index++, "Employee.City", "");
			ssState = r.ReadText(index++, "Employee.State", "");
			ssIsActive = r.ReadBoolean(index++, "Employee.IsActive", false);
			ssUpdateOn = r.ReadDateTime(index++, "Employee.UpdateOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedOn = r.ReadDateTime(index++, "Employee.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedBy = r.ReadLongInteger(index++, "Employee.CreatedBy", 0L);
			ssUpdateBy = r.ReadLongInteger(index++, "Employee.UpdateBy", 0L);
			ChangedAttributes = new BitArray(18, false);
			OptimizedAttributes = new BitArray(18, false);
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
		public void ReadIM(ENEmployeeEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENEmployeeEntityRecord a, ENEmployeeEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssUserName != b.ssUserName) return false;
			if (a.ssRegistration != b.ssRegistration) return false;
			if (a.ssFullName != b.ssFullName) return false;
			if (a.ssJobTitle != b.ssJobTitle) return false;
			if (a.ssDepartment != b.ssDepartment) return false;
			if (a.ssBranch != b.ssBranch) return false;
			if (a.ssTelePhone != b.ssTelePhone) return false;
			if (a.ssZipCode != b.ssZipCode) return false;
			if (a.ssStreet != b.ssStreet) return false;
			if (a.ssNeighborhood != b.ssNeighborhood) return false;
			if (a.ssCity != b.ssCity) return false;
			if (a.ssState != b.ssState) return false;
			if (a.ssIsActive != b.ssIsActive) return false;
			if (a.ssUpdateOn != b.ssUpdateOn) return false;
			if (a.ssCreatedOn != b.ssCreatedOn) return false;
			if (a.ssCreatedBy != b.ssCreatedBy) return false;
			if (a.ssUpdateBy != b.ssUpdateBy) return false;
			return true;
		}

		public static bool operator != (ENEmployeeEntityRecord a, ENEmployeeEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENEmployeeEntityRecord)) return false;
			return (this == (ENEmployeeEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssUserName.GetHashCode()
				^ ssRegistration.GetHashCode()
				^ ssFullName.GetHashCode()
				^ ssJobTitle.GetHashCode()
				^ ssDepartment.GetHashCode()
				^ ssBranch.GetHashCode()
				^ ssTelePhone.GetHashCode()
				^ ssZipCode.GetHashCode()
				^ ssStreet.GetHashCode()
				^ ssNeighborhood.GetHashCode()
				^ ssCity.GetHashCode()
				^ ssState.GetHashCode()
				^ ssIsActive.GetHashCode()
				^ ssUpdateOn.GetHashCode()
				^ ssCreatedOn.GetHashCode()
				^ ssCreatedBy.GetHashCode()
				^ ssUpdateBy.GetHashCode()
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

		public ENEmployeeEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(18, true);
			OptimizedAttributes = new BitArray(18, false);
			_ssid = 0;
			_ssUserName = "";
			_ssRegistration = "";
			_ssFullName = "";
			_ssJobTitle = 0;
			_ssDepartment = 0;
			_ssBranch = 0;
			_ssTelePhone = "";
			_ssZipCode = "";
			_ssStreet = "";
			_ssNeighborhood = "";
			_ssCity = "";
			_ssState = "";
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0L;
			_ssUpdateBy = 0L;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUserName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUserName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUserName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssRegistration", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssRegistration' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssRegistration = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssFullName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssFullName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssFullName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssJobTitle", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssJobTitle' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssJobTitle = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDepartment", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDepartment' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDepartment = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssBranch", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssBranch' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssBranch = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssTelePhone", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssTelePhone' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssTelePhone = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssZipCode", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssZipCode' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssZipCode = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssStreet", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssStreet' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssStreet = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssNeighborhood", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssNeighborhood' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssNeighborhood = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCity", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCity' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCity = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssState", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssState' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssState = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssIsActive", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIsActive' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIsActive = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedBy = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateBy = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENEmployeeEntityRecord Duplicate() {
			ENEmployeeEntityRecord t;
			t._ssid = this._ssid;
			t._ssUserName = this._ssUserName;
			t._ssRegistration = this._ssRegistration;
			t._ssFullName = this._ssFullName;
			t._ssJobTitle = this._ssJobTitle;
			t._ssDepartment = this._ssDepartment;
			t._ssBranch = this._ssBranch;
			t._ssTelePhone = this._ssTelePhone;
			t._ssZipCode = this._ssZipCode;
			t._ssStreet = this._ssStreet;
			t._ssNeighborhood = this._ssNeighborhood;
			t._ssCity = this._ssCity;
			t._ssState = this._ssState;
			t._ssIsActive = this._ssIsActive;
			t._ssUpdateOn = this._ssUpdateOn;
			t._ssCreatedOn = this._ssCreatedOn;
			t._ssCreatedBy = this._ssCreatedBy;
			t._ssUpdateBy = this._ssUpdateBy;
			t.ChangedAttributes = new BitArray(18);
			t.OptimizedAttributes = new BitArray(18);
			for (int i = 0; i < 18; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".id")) VarValue.AppendAttribute(recordElem, "id", ssid, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UserName")) VarValue.AppendAttribute(recordElem, "UserName", ssUserName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "UserName");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Registration")) VarValue.AppendAttribute(recordElem, "Registration", ssRegistration, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Registration");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".FullName")) VarValue.AppendAttribute(recordElem, "FullName", ssFullName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "FullName");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".JobTitle")) VarValue.AppendAttribute(recordElem, "JobTitle", ssJobTitle, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "JobTitle");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Department")) VarValue.AppendAttribute(recordElem, "Department", ssDepartment, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "Department");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Branch")) VarValue.AppendAttribute(recordElem, "Branch", ssBranch, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "Branch");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".TelePhone")) VarValue.AppendAttribute(recordElem, "TelePhone", ssTelePhone, detailLevel, TypeKind.PhoneNumber); else VarValue.AppendOptimizedAttribute(recordElem, "TelePhone");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ZipCode")) VarValue.AppendAttribute(recordElem, "ZipCode", ssZipCode, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "ZipCode");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Street")) VarValue.AppendAttribute(recordElem, "Street", ssStreet, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Street");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Neighborhood")) VarValue.AppendAttribute(recordElem, "Neighborhood", ssNeighborhood, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Neighborhood");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".City")) VarValue.AppendAttribute(recordElem, "City", ssCity, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "City");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".State")) VarValue.AppendAttribute(recordElem, "State", ssState, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "State");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsActive")) VarValue.AppendAttribute(recordElem, "IsActive", ssIsActive, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsActive");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateOn")) VarValue.AppendAttribute(recordElem, "UpdateOn", ssUpdateOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedOn")) VarValue.AppendAttribute(recordElem, "CreatedOn", ssCreatedOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedBy")) VarValue.AppendAttribute(recordElem, "CreatedBy", ssCreatedBy, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedBy");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateBy")) VarValue.AppendAttribute(recordElem, "UpdateBy", ssUpdateBy, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateBy");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
			} else if (head == "username") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UserName")) variable.Value = ssUserName; else variable.Optimized = true;
			} else if (head == "registration") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Registration")) variable.Value = ssRegistration; else variable.Optimized = true;
			} else if (head == "fullname") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".FullName")) variable.Value = ssFullName; else variable.Optimized = true;
			} else if (head == "jobtitle") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".JobTitle")) variable.Value = ssJobTitle; else variable.Optimized = true;
			} else if (head == "department") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Department")) variable.Value = ssDepartment; else variable.Optimized = true;
			} else if (head == "branch") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Branch")) variable.Value = ssBranch; else variable.Optimized = true;
			} else if (head == "telephone") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TelePhone")) variable.Value = ssTelePhone; else variable.Optimized = true;
			} else if (head == "zipcode") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ZipCode")) variable.Value = ssZipCode; else variable.Optimized = true;
			} else if (head == "street") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Street")) variable.Value = ssStreet; else variable.Optimized = true;
			} else if (head == "neighborhood") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Neighborhood")) variable.Value = ssNeighborhood; else variable.Optimized = true;
			} else if (head == "city") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".City")) variable.Value = ssCity; else variable.Optimized = true;
			} else if (head == "state") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".State")) variable.Value = ssState; else variable.Optimized = true;
			} else if (head == "isactive") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
			} else if (head == "updateon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateOn")) variable.Value = ssUpdateOn; else variable.Optimized = true;
			} else if (head == "createdon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
			} else if (head == "createdby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
			} else if (head == "updateby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateBy")) variable.Value = ssUpdateBy; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdUserName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdRegistration)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdFullName)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdJobTitle)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdDepartment)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdBranch)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdTelePhone)) {
				return ChangedAttributes[7];
			} else if (key.Equals(IdZipCode)) {
				return ChangedAttributes[8];
			} else if (key.Equals(IdStreet)) {
				return ChangedAttributes[9];
			} else if (key.Equals(IdNeighborhood)) {
				return ChangedAttributes[10];
			} else if (key.Equals(IdCity)) {
				return ChangedAttributes[11];
			} else if (key.Equals(IdState)) {
				return ChangedAttributes[12];
			} else if (key.Equals(IdIsActive)) {
				return ChangedAttributes[13];
			} else if (key.Equals(IdUpdateOn)) {
				return ChangedAttributes[14];
			} else if (key.Equals(IdCreatedOn)) {
				return ChangedAttributes[15];
			} else if (key.Equals(IdCreatedBy)) {
				return ChangedAttributes[16];
			} else if (key.Equals(IdUpdateBy)) {
				return ChangedAttributes[17];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdUserName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdRegistration)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdFullName)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdJobTitle)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdDepartment)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdBranch)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdTelePhone)) {
				return OptimizedAttributes[7];
			} else if (key.Equals(IdZipCode)) {
				return OptimizedAttributes[8];
			} else if (key.Equals(IdStreet)) {
				return OptimizedAttributes[9];
			} else if (key.Equals(IdNeighborhood)) {
				return OptimizedAttributes[10];
			} else if (key.Equals(IdCity)) {
				return OptimizedAttributes[11];
			} else if (key.Equals(IdState)) {
				return OptimizedAttributes[12];
			} else if (key.Equals(IdIsActive)) {
				return OptimizedAttributes[13];
			} else if (key.Equals(IdUpdateOn)) {
				return OptimizedAttributes[14];
			} else if (key.Equals(IdCreatedOn)) {
				return OptimizedAttributes[15];
			} else if (key.Equals(IdCreatedBy)) {
				return OptimizedAttributes[16];
			} else if (key.Equals(IdUpdateBy)) {
				return OptimizedAttributes[17];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == IdUserName) {
				return ssUserName;
			} else if (key == IdRegistration) {
				return ssRegistration;
			} else if (key == IdFullName) {
				return ssFullName;
			} else if (key == IdJobTitle) {
				return ssJobTitle;
			} else if (key == IdDepartment) {
				return ssDepartment;
			} else if (key == IdBranch) {
				return ssBranch;
			} else if (key == IdTelePhone) {
				return ssTelePhone;
			} else if (key == IdZipCode) {
				return ssZipCode;
			} else if (key == IdStreet) {
				return ssStreet;
			} else if (key == IdNeighborhood) {
				return ssNeighborhood;
			} else if (key == IdCity) {
				return ssCity;
			} else if (key == IdState) {
				return ssState;
			} else if (key == IdIsActive) {
				return ssIsActive;
			} else if (key == IdUpdateOn) {
				return ssUpdateOn;
			} else if (key == IdCreatedOn) {
				return ssCreatedOn;
			} else if (key == IdCreatedBy) {
				return ssCreatedBy;
			} else if (key == IdUpdateBy) {
				return ssUpdateBy;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(18);
			OptimizedAttributes = new BitArray(18);
			if (other == null) return;
			ssid = (int) other.AttributeGet(Idid);
			ChangedAttributes[0] = other.ChangedAttributeGet(Idid);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(Idid);
			ssUserName = (string) other.AttributeGet(IdUserName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdUserName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdUserName);
			ssRegistration = (string) other.AttributeGet(IdRegistration);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdRegistration);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdRegistration);
			ssFullName = (string) other.AttributeGet(IdFullName);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdFullName);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdFullName);
			ssJobTitle = (int) other.AttributeGet(IdJobTitle);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdJobTitle);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdJobTitle);
			ssDepartment = (int) other.AttributeGet(IdDepartment);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdDepartment);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdDepartment);
			ssBranch = (int) other.AttributeGet(IdBranch);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdBranch);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdBranch);
			ssTelePhone = (string) other.AttributeGet(IdTelePhone);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdTelePhone);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdTelePhone);
			ssZipCode = (string) other.AttributeGet(IdZipCode);
			ChangedAttributes[8] = other.ChangedAttributeGet(IdZipCode);
			OptimizedAttributes[8] = other.OptimizedAttributeGet(IdZipCode);
			ssStreet = (string) other.AttributeGet(IdStreet);
			ChangedAttributes[9] = other.ChangedAttributeGet(IdStreet);
			OptimizedAttributes[9] = other.OptimizedAttributeGet(IdStreet);
			ssNeighborhood = (string) other.AttributeGet(IdNeighborhood);
			ChangedAttributes[10] = other.ChangedAttributeGet(IdNeighborhood);
			OptimizedAttributes[10] = other.OptimizedAttributeGet(IdNeighborhood);
			ssCity = (string) other.AttributeGet(IdCity);
			ChangedAttributes[11] = other.ChangedAttributeGet(IdCity);
			OptimizedAttributes[11] = other.OptimizedAttributeGet(IdCity);
			ssState = (string) other.AttributeGet(IdState);
			ChangedAttributes[12] = other.ChangedAttributeGet(IdState);
			OptimizedAttributes[12] = other.OptimizedAttributeGet(IdState);
			ssIsActive = (bool) other.AttributeGet(IdIsActive);
			ChangedAttributes[13] = other.ChangedAttributeGet(IdIsActive);
			OptimizedAttributes[13] = other.OptimizedAttributeGet(IdIsActive);
			ssUpdateOn = (DateTime) other.AttributeGet(IdUpdateOn);
			ChangedAttributes[14] = other.ChangedAttributeGet(IdUpdateOn);
			OptimizedAttributes[14] = other.OptimizedAttributeGet(IdUpdateOn);
			ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
			ChangedAttributes[15] = other.ChangedAttributeGet(IdCreatedOn);
			OptimizedAttributes[15] = other.OptimizedAttributeGet(IdCreatedOn);
			ssCreatedBy = (long) other.AttributeGet(IdCreatedBy);
			ChangedAttributes[16] = other.ChangedAttributeGet(IdCreatedBy);
			OptimizedAttributes[16] = other.OptimizedAttributeGet(IdCreatedBy);
			ssUpdateBy = (long) other.AttributeGet(IdUpdateBy);
			ChangedAttributes[17] = other.ChangedAttributeGet(IdUpdateBy);
			OptimizedAttributes[17] = other.OptimizedAttributeGet(IdUpdateBy);
		}
		public bool IsDefault() {
			ENEmployeeEntityRecord defaultStruct = new ENEmployeeEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssUserName != defaultStruct.ssUserName) return false;
			if (this.ssRegistration != defaultStruct.ssRegistration) return false;
			if (this.ssFullName != defaultStruct.ssFullName) return false;
			if (this.ssJobTitle != defaultStruct.ssJobTitle) return false;
			if (this.ssDepartment != defaultStruct.ssDepartment) return false;
			if (this.ssBranch != defaultStruct.ssBranch) return false;
			if (this.ssTelePhone != defaultStruct.ssTelePhone) return false;
			if (this.ssZipCode != defaultStruct.ssZipCode) return false;
			if (this.ssStreet != defaultStruct.ssStreet) return false;
			if (this.ssNeighborhood != defaultStruct.ssNeighborhood) return false;
			if (this.ssCity != defaultStruct.ssCity) return false;
			if (this.ssState != defaultStruct.ssState) return false;
			if (this.ssIsActive != defaultStruct.ssIsActive) return false;
			if (this.ssUpdateOn != defaultStruct.ssUpdateOn) return false;
			if (this.ssCreatedOn != defaultStruct.ssCreatedOn) return false;
			if (this.ssCreatedBy != defaultStruct.ssCreatedBy) return false;
			if (this.ssUpdateBy != defaultStruct.ssUpdateBy) return false;
			return true;
		}
	} // ENEmployeeEntityRecord

	public class ENEmployeePhotoEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "ef158d7b-f666-4ddd-8da2-8958459111da", "e1942fbb-5156-4fa5-8e45-7e2b9d11af69", "EmployeePhoto", "[Outsystems].[dbo].[EmployeePhoto]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Outsystems].[dbo].[EmployeePhoto]"; 
					}
				} catch {
					return "[Outsystems].[dbo].[EmployeePhoto]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENEmployeePhotoEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "filename", "FileName"
			}
			, { "file", "File"
			}
			, { "isactive", "IsActive"
			}
			, { "updateon", "UpdateOn"
			}
			, { "createdon", "CreatedOn"
			}
			, { "createdby", "CreatedBy"
			}
			, { "updateby", "UpdateBy"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENEmployeePhotoEntityConfiguration.GetPhysicalTableName();
		}
	} // ENEmployeePhotoEntity

	/// <summary>
	/// Entity <code>ENEmployeePhotoEntityRecord</code> that represents the Service Studio entity
	///  <code>EmployeePhoto</code> <p> Description: A Photo of the employee</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("EmployeePhoto", "uy+U4VZRpU+ORX4rnRGvaQ", "e40V72b23U2NoolYRZER2g", 0, "[Outsystems].[dbo].[EmployeePhoto]", null)]
	[Serializable()]
	public partial struct ENEmployeePhotoEntityRecord: ISerializable, ITypedRecord<ENEmployeePhotoEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*fJ4JfSt6UE+vpwmOogn9DA");
		internal static readonly GlobalObjectKey IdFileName = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*zHxKXRDsGk+_WOZtXv5Rzw");
		internal static readonly GlobalObjectKey IdFile = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*Ty018qj__0uXnktjKrEmsw");
		internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*9eDvXofCbUyfD8n3vGBYKA");
		internal static readonly GlobalObjectKey IdUpdateOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*xWAV+9CF+UOoEzRDnKghxw");
		internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*Ukmh7J69Jku8Z8KOAppx2w");
		internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*M4HsJPz+s02CI4jj72CwPQ");
		internal static readonly GlobalObjectKey IdUpdateBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*rZ0vZIECx0OiYBAnp5VZpg");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("id", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("id")]
		private int _ssid;
		public int ssid {
			get {
				return _ssid;
			}
			set {
				if ((_ssid!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssid = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("FileName", 150, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("FileName")]
		private string _ssFileName;
		public string ssFileName {
			get {
				return _ssFileName;
			}
			set {
				if ((_ssFileName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssFileName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("File", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("File")]
		private byte[] _ssFile;
		public byte[] ssFile {
			get {
				return _ssFile;
			}
			set {
				if ((_ssFile!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssFile = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("IsActive", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("IsActive")]
		private bool _ssIsActive;
		public bool ssIsActive {
			get {
				return _ssIsActive;
			}
			set {
				if ((_ssIsActive!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssIsActive = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateOn")]
		private DateTime _ssUpdateOn;
		public DateTime ssUpdateOn {
			get {
				return _ssUpdateOn;
			}
			set {
				if ((_ssUpdateOn!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedOn")]
		private DateTime _ssCreatedOn;
		public DateTime ssCreatedOn {
			get {
				return _ssCreatedOn;
			}
			set {
				if ((_ssCreatedOn!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssCreatedOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedBy", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedBy")]
		private long _ssCreatedBy;
		public long ssCreatedBy {
			get {
				return _ssCreatedBy;
			}
			set {
				if ((_ssCreatedBy!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssCreatedBy = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateBy", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateBy")]
		private long _ssUpdateBy;
		public long ssUpdateBy {
			get {
				return _ssUpdateBy;
			}
			set {
				if ((_ssUpdateBy!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssUpdateBy = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENEmployeePhotoEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssid = 0;
			_ssFileName = "";
			_ssFile = new byte[] {};
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0L;
			_ssUpdateBy = 0L;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssid = r.ReadEntityReference(index++, "EmployeePhoto.id", 0);
			ssFileName = r.ReadText(index++, "EmployeePhoto.FileName", "");
			ssFile = r.ReadBinaryData(index++, "EmployeePhoto.File", new byte[] {});
			ssIsActive = r.ReadBoolean(index++, "EmployeePhoto.IsActive", false);
			ssUpdateOn = r.ReadDateTime(index++, "EmployeePhoto.UpdateOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedOn = r.ReadDateTime(index++, "EmployeePhoto.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedBy = r.ReadLongInteger(index++, "EmployeePhoto.CreatedBy", 0L);
			ssUpdateBy = r.ReadLongInteger(index++, "EmployeePhoto.UpdateBy", 0L);
			ChangedAttributes = new BitArray(8, false);
			OptimizedAttributes = new BitArray(8, false);
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
		public void ReadIM(ENEmployeePhotoEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENEmployeePhotoEntityRecord a, ENEmployeePhotoEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssFileName != b.ssFileName) return false;
			if (!RuntimePlatformUtils.CompareByteArrays(a.ssFile, b.ssFile)) return false;
			if (a.ssIsActive != b.ssIsActive) return false;
			if (a.ssUpdateOn != b.ssUpdateOn) return false;
			if (a.ssCreatedOn != b.ssCreatedOn) return false;
			if (a.ssCreatedBy != b.ssCreatedBy) return false;
			if (a.ssUpdateBy != b.ssUpdateBy) return false;
			return true;
		}

		public static bool operator != (ENEmployeePhotoEntityRecord a, ENEmployeePhotoEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENEmployeePhotoEntityRecord)) return false;
			return (this == (ENEmployeePhotoEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssFileName.GetHashCode()
				^ ssFile.GetHashCode()
				^ ssIsActive.GetHashCode()
				^ ssUpdateOn.GetHashCode()
				^ ssCreatedOn.GetHashCode()
				^ ssCreatedBy.GetHashCode()
				^ ssUpdateBy.GetHashCode()
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

		public ENEmployeePhotoEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssid = 0;
			_ssFileName = "";
			_ssFile = new byte[] {};
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0L;
			_ssUpdateBy = 0L;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssFileName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssFileName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssFileName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssFile", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssFile' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssFile = (byte[]) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssIsActive", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIsActive' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIsActive = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedBy = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateBy = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENEmployeePhotoEntityRecord Duplicate() {
			ENEmployeePhotoEntityRecord t;
			t._ssid = this._ssid;
			t._ssFileName = this._ssFileName;
			if (this._ssFile != null) {
				t._ssFile = (byte[]) this._ssFile.Clone();
			} else {
				t._ssFile = null;
			}
			t._ssIsActive = this._ssIsActive;
			t._ssUpdateOn = this._ssUpdateOn;
			t._ssCreatedOn = this._ssCreatedOn;
			t._ssCreatedBy = this._ssCreatedBy;
			t._ssUpdateBy = this._ssUpdateBy;
			t.ChangedAttributes = new BitArray(8);
			t.OptimizedAttributes = new BitArray(8);
			for (int i = 0; i < 8; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".id")) VarValue.AppendAttribute(recordElem, "id", ssid, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".FileName")) VarValue.AppendAttribute(recordElem, "FileName", ssFileName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "FileName");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".File")) VarValue.AppendAttribute(recordElem, "File", ssFile, detailLevel, TypeKind.BinaryData); else VarValue.AppendOptimizedAttribute(recordElem, "File");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsActive")) VarValue.AppendAttribute(recordElem, "IsActive", ssIsActive, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsActive");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateOn")) VarValue.AppendAttribute(recordElem, "UpdateOn", ssUpdateOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedOn")) VarValue.AppendAttribute(recordElem, "CreatedOn", ssCreatedOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedBy")) VarValue.AppendAttribute(recordElem, "CreatedBy", ssCreatedBy, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedBy");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateBy")) VarValue.AppendAttribute(recordElem, "UpdateBy", ssUpdateBy, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateBy");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
			} else if (head == "filename") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".FileName")) variable.Value = ssFileName; else variable.Optimized = true;
			} else if (head == "file") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".File")) variable.Value = ssFile; else variable.Optimized = true;
			} else if (head == "isactive") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
			} else if (head == "updateon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateOn")) variable.Value = ssUpdateOn; else variable.Optimized = true;
			} else if (head == "createdon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
			} else if (head == "createdby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
			} else if (head == "updateby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateBy")) variable.Value = ssUpdateBy; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdFileName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdFile)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdIsActive)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateOn)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdCreatedOn)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdCreatedBy)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdUpdateBy)) {
				return ChangedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdFileName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdFile)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdIsActive)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateOn)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdCreatedOn)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdCreatedBy)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdUpdateBy)) {
				return OptimizedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == IdFileName) {
				return ssFileName;
			} else if (key == IdFile) {
				return ssFile;
			} else if (key == IdIsActive) {
				return ssIsActive;
			} else if (key == IdUpdateOn) {
				return ssUpdateOn;
			} else if (key == IdCreatedOn) {
				return ssCreatedOn;
			} else if (key == IdCreatedBy) {
				return ssCreatedBy;
			} else if (key == IdUpdateBy) {
				return ssUpdateBy;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(8);
			OptimizedAttributes = new BitArray(8);
			if (other == null) return;
			ssid = (int) other.AttributeGet(Idid);
			ChangedAttributes[0] = other.ChangedAttributeGet(Idid);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(Idid);
			ssFileName = (string) other.AttributeGet(IdFileName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdFileName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFileName);
			ssFile = (byte[]) other.AttributeGet(IdFile);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdFile);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdFile);
			ssIsActive = (bool) other.AttributeGet(IdIsActive);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdIsActive);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsActive);
			ssUpdateOn = (DateTime) other.AttributeGet(IdUpdateOn);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateOn);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateOn);
			ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedOn);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedOn);
			ssCreatedBy = (long) other.AttributeGet(IdCreatedBy);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedBy);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedBy);
			ssUpdateBy = (long) other.AttributeGet(IdUpdateBy);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdUpdateBy);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdUpdateBy);
		}
		public bool IsDefault() {
			ENEmployeePhotoEntityRecord defaultStruct = new ENEmployeePhotoEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssFileName != defaultStruct.ssFileName) return false;
			if (!RuntimePlatformUtils.CompareByteArrays(this.ssFile, defaultStruct.ssFile)) return false;
			if (this.ssIsActive != defaultStruct.ssIsActive) return false;
			if (this.ssUpdateOn != defaultStruct.ssUpdateOn) return false;
			if (this.ssCreatedOn != defaultStruct.ssCreatedOn) return false;
			if (this.ssCreatedBy != defaultStruct.ssCreatedBy) return false;
			if (this.ssUpdateBy != defaultStruct.ssUpdateBy) return false;
			return true;
		}
	} // ENEmployeePhotoEntityRecord

	public class ENPayrollEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "ef158d7b-f666-4ddd-8da2-8958459111da", "73257a35-b159-4502-a30c-09e074513ba1", "Payroll", "[Outsystems].[dbo].[Payroll]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Outsystems].[dbo].[Payroll]"; 
					}
				} catch {
					return "[Outsystems].[dbo].[Payroll]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENPayrollEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "pdfname", "PdfName"
			}
			, { "file", "File"
			}
			, { "isactive", "IsActive"
			}
			, { "updateon", "UpdateOn"
			}
			, { "createdon", "CreatedOn"
			}
			, { "createdby", "CreatedBy"
			}
			, { "updateby", "UpdateBy"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENPayrollEntityConfiguration.GetPhysicalTableName();
		}
	} // ENPayrollEntity

	/// <summary>
	/// Entity <code>ENPayrollEntityRecord</code> that represents the Service Studio entity
	///  <code>Payroll</code> <p> Description: Save the payroll files</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Payroll", "NXolc1mxAkWjDAngdFE7oQ", "e40V72b23U2NoolYRZER2g", 0, "[Outsystems].[dbo].[Payroll]", null)]
	[Serializable()]
	public partial struct ENPayrollEntityRecord: ISerializable, ITypedRecord<ENPayrollEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*67WrI3dp4ECP+o8qlH+0_g");
		internal static readonly GlobalObjectKey IdPdfName = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*bJmUwjR+VkGTfFTU721n6w");
		internal static readonly GlobalObjectKey IdFile = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*PqgbklDTMEy0UgxmKVx+1Q");
		internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*SWXA0dMrWEiZ9dFNHZ2Rzg");
		internal static readonly GlobalObjectKey IdUpdateOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*zbK_s9vY7U2C9QnZwDaXaw");
		internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*05ztefWoEUe2L4tfmgjTFQ");
		internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*dk+2KhMFbkW4QRk_MaeTbQ");
		internal static readonly GlobalObjectKey IdUpdateBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*D1vsHCy0l0exjGB4ikZIXQ");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("id", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("id")]
		private int _ssid;
		public int ssid {
			get {
				return _ssid;
			}
			set {
				if ((_ssid!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(8, true);
					_ssid = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PdfName", 150, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("PdfName")]
		private string _ssPdfName;
		public string ssPdfName {
			get {
				return _ssPdfName;
			}
			set {
				if ((_ssPdfName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssPdfName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("File", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("File")]
		private byte[] _ssFile;
		public byte[] ssFile {
			get {
				return _ssFile;
			}
			set {
				if ((_ssFile!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssFile = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("IsActive", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("IsActive")]
		private bool _ssIsActive;
		public bool ssIsActive {
			get {
				return _ssIsActive;
			}
			set {
				if ((_ssIsActive!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssIsActive = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateOn")]
		private DateTime _ssUpdateOn;
		public DateTime ssUpdateOn {
			get {
				return _ssUpdateOn;
			}
			set {
				if ((_ssUpdateOn!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedOn")]
		private DateTime _ssCreatedOn;
		public DateTime ssCreatedOn {
			get {
				return _ssCreatedOn;
			}
			set {
				if ((_ssCreatedOn!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssCreatedOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedBy", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedBy")]
		private long _ssCreatedBy;
		public long ssCreatedBy {
			get {
				return _ssCreatedBy;
			}
			set {
				if ((_ssCreatedBy!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssCreatedBy = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateBy", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateBy")]
		private long _ssUpdateBy;
		public long ssUpdateBy {
			get {
				return _ssUpdateBy;
			}
			set {
				if ((_ssUpdateBy!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssUpdateBy = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENPayrollEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssid = 0;
			_ssPdfName = "";
			_ssFile = new byte[] {};
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0L;
			_ssUpdateBy = 0L;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssid = r.ReadInteger(index++, "Payroll.id", 0);
			ssPdfName = r.ReadText(index++, "Payroll.PdfName", "");
			ssFile = r.ReadBinaryData(index++, "Payroll.File", new byte[] {});
			ssIsActive = r.ReadBoolean(index++, "Payroll.IsActive", false);
			ssUpdateOn = r.ReadDateTime(index++, "Payroll.UpdateOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedOn = r.ReadDateTime(index++, "Payroll.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedBy = r.ReadLongInteger(index++, "Payroll.CreatedBy", 0L);
			ssUpdateBy = r.ReadLongInteger(index++, "Payroll.UpdateBy", 0L);
			ChangedAttributes = new BitArray(8, false);
			OptimizedAttributes = new BitArray(8, false);
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
		public void ReadIM(ENPayrollEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENPayrollEntityRecord a, ENPayrollEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssPdfName != b.ssPdfName) return false;
			if (!RuntimePlatformUtils.CompareByteArrays(a.ssFile, b.ssFile)) return false;
			if (a.ssIsActive != b.ssIsActive) return false;
			if (a.ssUpdateOn != b.ssUpdateOn) return false;
			if (a.ssCreatedOn != b.ssCreatedOn) return false;
			if (a.ssCreatedBy != b.ssCreatedBy) return false;
			if (a.ssUpdateBy != b.ssUpdateBy) return false;
			return true;
		}

		public static bool operator != (ENPayrollEntityRecord a, ENPayrollEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENPayrollEntityRecord)) return false;
			return (this == (ENPayrollEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssPdfName.GetHashCode()
				^ ssFile.GetHashCode()
				^ ssIsActive.GetHashCode()
				^ ssUpdateOn.GetHashCode()
				^ ssCreatedOn.GetHashCode()
				^ ssCreatedBy.GetHashCode()
				^ ssUpdateBy.GetHashCode()
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

		public ENPayrollEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssid = 0;
			_ssPdfName = "";
			_ssFile = new byte[] {};
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0L;
			_ssUpdateBy = 0L;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssPdfName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssPdfName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssPdfName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssFile", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssFile' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssFile = (byte[]) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssIsActive", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIsActive' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIsActive = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedBy = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateBy = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENPayrollEntityRecord Duplicate() {
			ENPayrollEntityRecord t;
			t._ssid = this._ssid;
			t._ssPdfName = this._ssPdfName;
			if (this._ssFile != null) {
				t._ssFile = (byte[]) this._ssFile.Clone();
			} else {
				t._ssFile = null;
			}
			t._ssIsActive = this._ssIsActive;
			t._ssUpdateOn = this._ssUpdateOn;
			t._ssCreatedOn = this._ssCreatedOn;
			t._ssCreatedBy = this._ssCreatedBy;
			t._ssUpdateBy = this._ssUpdateBy;
			t.ChangedAttributes = new BitArray(8);
			t.OptimizedAttributes = new BitArray(8);
			for (int i = 0; i < 8; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".id")) VarValue.AppendAttribute(recordElem, "id", ssid, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".PdfName")) VarValue.AppendAttribute(recordElem, "PdfName", ssPdfName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "PdfName");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".File")) VarValue.AppendAttribute(recordElem, "File", ssFile, detailLevel, TypeKind.BinaryData); else VarValue.AppendOptimizedAttribute(recordElem, "File");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsActive")) VarValue.AppendAttribute(recordElem, "IsActive", ssIsActive, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsActive");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateOn")) VarValue.AppendAttribute(recordElem, "UpdateOn", ssUpdateOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedOn")) VarValue.AppendAttribute(recordElem, "CreatedOn", ssCreatedOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedBy")) VarValue.AppendAttribute(recordElem, "CreatedBy", ssCreatedBy, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedBy");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateBy")) VarValue.AppendAttribute(recordElem, "UpdateBy", ssUpdateBy, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateBy");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
			} else if (head == "pdfname") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".PdfName")) variable.Value = ssPdfName; else variable.Optimized = true;
			} else if (head == "file") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".File")) variable.Value = ssFile; else variable.Optimized = true;
			} else if (head == "isactive") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
			} else if (head == "updateon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateOn")) variable.Value = ssUpdateOn; else variable.Optimized = true;
			} else if (head == "createdon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
			} else if (head == "createdby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
			} else if (head == "updateby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateBy")) variable.Value = ssUpdateBy; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdPdfName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdFile)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdIsActive)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateOn)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdCreatedOn)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdCreatedBy)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdUpdateBy)) {
				return ChangedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdPdfName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdFile)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdIsActive)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateOn)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdCreatedOn)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdCreatedBy)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdUpdateBy)) {
				return OptimizedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == IdPdfName) {
				return ssPdfName;
			} else if (key == IdFile) {
				return ssFile;
			} else if (key == IdIsActive) {
				return ssIsActive;
			} else if (key == IdUpdateOn) {
				return ssUpdateOn;
			} else if (key == IdCreatedOn) {
				return ssCreatedOn;
			} else if (key == IdCreatedBy) {
				return ssCreatedBy;
			} else if (key == IdUpdateBy) {
				return ssUpdateBy;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(8);
			OptimizedAttributes = new BitArray(8);
			if (other == null) return;
			ssid = (int) other.AttributeGet(Idid);
			ChangedAttributes[0] = other.ChangedAttributeGet(Idid);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(Idid);
			ssPdfName = (string) other.AttributeGet(IdPdfName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdPdfName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdPdfName);
			ssFile = (byte[]) other.AttributeGet(IdFile);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdFile);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdFile);
			ssIsActive = (bool) other.AttributeGet(IdIsActive);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdIsActive);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsActive);
			ssUpdateOn = (DateTime) other.AttributeGet(IdUpdateOn);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateOn);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateOn);
			ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedOn);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedOn);
			ssCreatedBy = (long) other.AttributeGet(IdCreatedBy);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedBy);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedBy);
			ssUpdateBy = (long) other.AttributeGet(IdUpdateBy);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdUpdateBy);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdUpdateBy);
		}
		public bool IsDefault() {
			ENPayrollEntityRecord defaultStruct = new ENPayrollEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssPdfName != defaultStruct.ssPdfName) return false;
			if (!RuntimePlatformUtils.CompareByteArrays(this.ssFile, defaultStruct.ssFile)) return false;
			if (this.ssIsActive != defaultStruct.ssIsActive) return false;
			if (this.ssUpdateOn != defaultStruct.ssUpdateOn) return false;
			if (this.ssCreatedOn != defaultStruct.ssCreatedOn) return false;
			if (this.ssCreatedBy != defaultStruct.ssCreatedBy) return false;
			if (this.ssUpdateBy != defaultStruct.ssUpdateBy) return false;
			return true;
		}
	} // ENPayrollEntityRecord

	public class ENTimeSheetEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "ef158d7b-f666-4ddd-8da2-8958459111da", "caf27eac-e097-40fe-a013-f913d4ad278e", "TimeSheet", "[Outsystems].[dbo].[TimeSheet]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Outsystems].[dbo].[TimeSheet]"; 
					}
				} catch {
					return "[Outsystems].[dbo].[TimeSheet]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENTimeSheetEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "pdfname", "PdfName"
			}
			, { "file", "File"
			}
			, { "isactive", "IsActive"
			}
			, { "updateon", "UpdateOn"
			}
			, { "createdon", "CreatedOn"
			}
			, { "createdby", "CreatedBy"
			}
			, { "updateby", "UpdateBy"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENTimeSheetEntityConfiguration.GetPhysicalTableName();
		}
	} // ENTimeSheetEntity

	/// <summary>
	/// Entity <code>ENTimeSheetEntityRecord</code> that represents the Service Studio entity
	///  <code>TimeSheet</code> <p> Description: Save the TimeSheet  files</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("TimeSheet", "rH7yypfg_kCgE_kT1K0njg", "e40V72b23U2NoolYRZER2g", 0, "[Outsystems].[dbo].[TimeSheet]", null)]
	[Serializable()]
	public partial struct ENTimeSheetEntityRecord: ISerializable, ITypedRecord<ENTimeSheetEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*zC5Det4_r0KRm1DdJLUQ2A");
		internal static readonly GlobalObjectKey IdPdfName = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*Lr6gmGwdR0+XsA5wJcHXeA");
		internal static readonly GlobalObjectKey IdFile = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*rKjOCc7D806uWIrmmBVyuA");
		internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*1H5nxaOX20KY_qfulocvaA");
		internal static readonly GlobalObjectKey IdUpdateOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*kOKWV+xUEk2hGKQo52pMlQ");
		internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*4kKUnu3b00m+V1po1yPv1g");
		internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*BCo5Sbp5akG6WcBtodMR1A");
		internal static readonly GlobalObjectKey IdUpdateBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*ZaWAKHkcQECyWNC16gvIQw");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("id", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("id")]
		private int _ssid;
		public int ssid {
			get {
				return _ssid;
			}
			set {
				if ((_ssid!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(8, true);
					_ssid = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PdfName", 150, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("PdfName")]
		private string _ssPdfName;
		public string ssPdfName {
			get {
				return _ssPdfName;
			}
			set {
				if ((_ssPdfName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssPdfName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("File", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("File")]
		private byte[] _ssFile;
		public byte[] ssFile {
			get {
				return _ssFile;
			}
			set {
				if ((_ssFile!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssFile = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("IsActive", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("IsActive")]
		private bool _ssIsActive;
		public bool ssIsActive {
			get {
				return _ssIsActive;
			}
			set {
				if ((_ssIsActive!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssIsActive = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateOn")]
		private DateTime _ssUpdateOn;
		public DateTime ssUpdateOn {
			get {
				return _ssUpdateOn;
			}
			set {
				if ((_ssUpdateOn!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedOn")]
		private DateTime _ssCreatedOn;
		public DateTime ssCreatedOn {
			get {
				return _ssCreatedOn;
			}
			set {
				if ((_ssCreatedOn!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssCreatedOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedBy", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedBy")]
		private long _ssCreatedBy;
		public long ssCreatedBy {
			get {
				return _ssCreatedBy;
			}
			set {
				if ((_ssCreatedBy!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssCreatedBy = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateBy", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateBy")]
		private long _ssUpdateBy;
		public long ssUpdateBy {
			get {
				return _ssUpdateBy;
			}
			set {
				if ((_ssUpdateBy!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssUpdateBy = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENTimeSheetEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssid = 0;
			_ssPdfName = "";
			_ssFile = new byte[] {};
			_ssIsActive = false;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0L;
			_ssUpdateBy = 0L;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssid = r.ReadInteger(index++, "TimeSheet.id", 0);
			ssPdfName = r.ReadText(index++, "TimeSheet.PdfName", "");
			ssFile = r.ReadBinaryData(index++, "TimeSheet.File", new byte[] {});
			ssIsActive = r.ReadBoolean(index++, "TimeSheet.IsActive", false);
			ssUpdateOn = r.ReadDateTime(index++, "TimeSheet.UpdateOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedOn = r.ReadDateTime(index++, "TimeSheet.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedBy = r.ReadLongInteger(index++, "TimeSheet.CreatedBy", 0L);
			ssUpdateBy = r.ReadLongInteger(index++, "TimeSheet.UpdateBy", 0L);
			ChangedAttributes = new BitArray(8, false);
			OptimizedAttributes = new BitArray(8, false);
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
		public void ReadIM(ENTimeSheetEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENTimeSheetEntityRecord a, ENTimeSheetEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssPdfName != b.ssPdfName) return false;
			if (!RuntimePlatformUtils.CompareByteArrays(a.ssFile, b.ssFile)) return false;
			if (a.ssIsActive != b.ssIsActive) return false;
			if (a.ssUpdateOn != b.ssUpdateOn) return false;
			if (a.ssCreatedOn != b.ssCreatedOn) return false;
			if (a.ssCreatedBy != b.ssCreatedBy) return false;
			if (a.ssUpdateBy != b.ssUpdateBy) return false;
			return true;
		}

		public static bool operator != (ENTimeSheetEntityRecord a, ENTimeSheetEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENTimeSheetEntityRecord)) return false;
			return (this == (ENTimeSheetEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssPdfName.GetHashCode()
				^ ssFile.GetHashCode()
				^ ssIsActive.GetHashCode()
				^ ssUpdateOn.GetHashCode()
				^ ssCreatedOn.GetHashCode()
				^ ssCreatedBy.GetHashCode()
				^ ssUpdateBy.GetHashCode()
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

		public ENTimeSheetEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssid = 0;
			_ssPdfName = "";
			_ssFile = new byte[] {};
			_ssIsActive = false;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0L;
			_ssUpdateBy = 0L;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssPdfName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssPdfName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssPdfName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssFile", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssFile' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssFile = (byte[]) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssIsActive", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIsActive' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIsActive = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedBy = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateBy = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENTimeSheetEntityRecord Duplicate() {
			ENTimeSheetEntityRecord t;
			t._ssid = this._ssid;
			t._ssPdfName = this._ssPdfName;
			if (this._ssFile != null) {
				t._ssFile = (byte[]) this._ssFile.Clone();
			} else {
				t._ssFile = null;
			}
			t._ssIsActive = this._ssIsActive;
			t._ssUpdateOn = this._ssUpdateOn;
			t._ssCreatedOn = this._ssCreatedOn;
			t._ssCreatedBy = this._ssCreatedBy;
			t._ssUpdateBy = this._ssUpdateBy;
			t.ChangedAttributes = new BitArray(8);
			t.OptimizedAttributes = new BitArray(8);
			for (int i = 0; i < 8; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".id")) VarValue.AppendAttribute(recordElem, "id", ssid, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".PdfName")) VarValue.AppendAttribute(recordElem, "PdfName", ssPdfName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "PdfName");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".File")) VarValue.AppendAttribute(recordElem, "File", ssFile, detailLevel, TypeKind.BinaryData); else VarValue.AppendOptimizedAttribute(recordElem, "File");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsActive")) VarValue.AppendAttribute(recordElem, "IsActive", ssIsActive, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsActive");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateOn")) VarValue.AppendAttribute(recordElem, "UpdateOn", ssUpdateOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedOn")) VarValue.AppendAttribute(recordElem, "CreatedOn", ssCreatedOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedBy")) VarValue.AppendAttribute(recordElem, "CreatedBy", ssCreatedBy, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedBy");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateBy")) VarValue.AppendAttribute(recordElem, "UpdateBy", ssUpdateBy, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateBy");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
			} else if (head == "pdfname") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".PdfName")) variable.Value = ssPdfName; else variable.Optimized = true;
			} else if (head == "file") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".File")) variable.Value = ssFile; else variable.Optimized = true;
			} else if (head == "isactive") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
			} else if (head == "updateon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateOn")) variable.Value = ssUpdateOn; else variable.Optimized = true;
			} else if (head == "createdon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
			} else if (head == "createdby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
			} else if (head == "updateby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateBy")) variable.Value = ssUpdateBy; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdPdfName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdFile)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdIsActive)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateOn)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdCreatedOn)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdCreatedBy)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdUpdateBy)) {
				return ChangedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdPdfName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdFile)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdIsActive)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateOn)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdCreatedOn)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdCreatedBy)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdUpdateBy)) {
				return OptimizedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == IdPdfName) {
				return ssPdfName;
			} else if (key == IdFile) {
				return ssFile;
			} else if (key == IdIsActive) {
				return ssIsActive;
			} else if (key == IdUpdateOn) {
				return ssUpdateOn;
			} else if (key == IdCreatedOn) {
				return ssCreatedOn;
			} else if (key == IdCreatedBy) {
				return ssCreatedBy;
			} else if (key == IdUpdateBy) {
				return ssUpdateBy;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(8);
			OptimizedAttributes = new BitArray(8);
			if (other == null) return;
			ssid = (int) other.AttributeGet(Idid);
			ChangedAttributes[0] = other.ChangedAttributeGet(Idid);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(Idid);
			ssPdfName = (string) other.AttributeGet(IdPdfName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdPdfName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdPdfName);
			ssFile = (byte[]) other.AttributeGet(IdFile);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdFile);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdFile);
			ssIsActive = (bool) other.AttributeGet(IdIsActive);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdIsActive);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsActive);
			ssUpdateOn = (DateTime) other.AttributeGet(IdUpdateOn);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateOn);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateOn);
			ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedOn);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedOn);
			ssCreatedBy = (long) other.AttributeGet(IdCreatedBy);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedBy);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedBy);
			ssUpdateBy = (long) other.AttributeGet(IdUpdateBy);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdUpdateBy);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdUpdateBy);
		}
		public bool IsDefault() {
			ENTimeSheetEntityRecord defaultStruct = new ENTimeSheetEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssPdfName != defaultStruct.ssPdfName) return false;
			if (!RuntimePlatformUtils.CompareByteArrays(this.ssFile, defaultStruct.ssFile)) return false;
			if (this.ssIsActive != defaultStruct.ssIsActive) return false;
			if (this.ssUpdateOn != defaultStruct.ssUpdateOn) return false;
			if (this.ssCreatedOn != defaultStruct.ssCreatedOn) return false;
			if (this.ssCreatedBy != defaultStruct.ssCreatedBy) return false;
			if (this.ssUpdateBy != defaultStruct.ssUpdateBy) return false;
			return true;
		}
	} // ENTimeSheetEntityRecord

	public class ENFaQEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "ef158d7b-f666-4ddd-8da2-8958459111da", "b733ee09-b353-4e73-87e9-41c42d9e4fd6", "FaQ", "[Outsystems].[dbo].[FaQ]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Outsystems].[dbo].[FaQ]"; 
					}
				} catch {
					return "[Outsystems].[dbo].[FaQ]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENFaQEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "question", "Question"
			}
			, { "answer", "Answer"
			}
			, { "isactive", "IsActive"
			}
			, { "updateon", "UpdateOn"
			}
			, { "createdon", "CreatedOn"
			}
			, { "createdby", "CreatedBy"
			}
			, { "updateby", "UpdateBy"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENFaQEntityConfiguration.GetPhysicalTableName();
		}
	} // ENFaQEntity

	/// <summary>
	/// Entity <code>ENFaQEntityRecord</code> that represents the Service Studio entity <code>FaQ</code>
	///  <p> Description: Question and Answers fo the employees</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("FaQ", "Ce4zt1Ozc06H6UHELZ5P1g", "e40V72b23U2NoolYRZER2g", 0, "[Outsystems].[dbo].[FaQ]", null)]
	[Serializable()]
	public partial struct ENFaQEntityRecord: ISerializable, ITypedRecord<ENFaQEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*znQxV0O53EmuzyqRshJJAQ");
		internal static readonly GlobalObjectKey IdQuestion = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*6tlM9vnfGEexgyQ0sSISrg");
		internal static readonly GlobalObjectKey IdAnswer = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*K25NSw+IH0W55N6M1_OQLQ");
		internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*+96M7Pse4U+jdzuedrw7EQ");
		internal static readonly GlobalObjectKey IdUpdateOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*JKAiGK+RqE2ljFRTWbA9zQ");
		internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*2491rESt1k+4_RSTTXOmow");
		internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*epdFGzx1U0aXNwHAjsxpXw");
		internal static readonly GlobalObjectKey IdUpdateBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*6ezOvTdOSEGmnWiAHE6fEw");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("id", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("id")]
		private int _ssid;
		public int ssid {
			get {
				return _ssid;
			}
			set {
				if ((_ssid!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(8, true);
					_ssid = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Question", 150, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Question")]
		private string _ssQuestion;
		public string ssQuestion {
			get {
				return _ssQuestion;
			}
			set {
				if ((_ssQuestion!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssQuestion = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Answer", 1000, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Answer")]
		private string _ssAnswer;
		public string ssAnswer {
			get {
				return _ssAnswer;
			}
			set {
				if ((_ssAnswer!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssAnswer = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("IsActive", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("IsActive")]
		private bool _ssIsActive;
		public bool ssIsActive {
			get {
				return _ssIsActive;
			}
			set {
				if ((_ssIsActive!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssIsActive = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateOn")]
		private DateTime _ssUpdateOn;
		public DateTime ssUpdateOn {
			get {
				return _ssUpdateOn;
			}
			set {
				if ((_ssUpdateOn!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedOn")]
		private DateTime _ssCreatedOn;
		public DateTime ssCreatedOn {
			get {
				return _ssCreatedOn;
			}
			set {
				if ((_ssCreatedOn!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssCreatedOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedBy", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedBy")]
		private long _ssCreatedBy;
		public long ssCreatedBy {
			get {
				return _ssCreatedBy;
			}
			set {
				if ((_ssCreatedBy!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssCreatedBy = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateBy", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateBy")]
		private long _ssUpdateBy;
		public long ssUpdateBy {
			get {
				return _ssUpdateBy;
			}
			set {
				if ((_ssUpdateBy!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssUpdateBy = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENFaQEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssid = 0;
			_ssQuestion = "";
			_ssAnswer = "";
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0L;
			_ssUpdateBy = 0L;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssid = r.ReadInteger(index++, "FaQ.id", 0);
			ssQuestion = r.ReadText(index++, "FaQ.Question", "");
			ssAnswer = r.ReadText(index++, "FaQ.Answer", "");
			ssIsActive = r.ReadBoolean(index++, "FaQ.IsActive", false);
			ssUpdateOn = r.ReadDateTime(index++, "FaQ.UpdateOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedOn = r.ReadDateTime(index++, "FaQ.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedBy = r.ReadLongInteger(index++, "FaQ.CreatedBy", 0L);
			ssUpdateBy = r.ReadLongInteger(index++, "FaQ.UpdateBy", 0L);
			ChangedAttributes = new BitArray(8, false);
			OptimizedAttributes = new BitArray(8, false);
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
		public void ReadIM(ENFaQEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENFaQEntityRecord a, ENFaQEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssQuestion != b.ssQuestion) return false;
			if (a.ssAnswer != b.ssAnswer) return false;
			if (a.ssIsActive != b.ssIsActive) return false;
			if (a.ssUpdateOn != b.ssUpdateOn) return false;
			if (a.ssCreatedOn != b.ssCreatedOn) return false;
			if (a.ssCreatedBy != b.ssCreatedBy) return false;
			if (a.ssUpdateBy != b.ssUpdateBy) return false;
			return true;
		}

		public static bool operator != (ENFaQEntityRecord a, ENFaQEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENFaQEntityRecord)) return false;
			return (this == (ENFaQEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssQuestion.GetHashCode()
				^ ssAnswer.GetHashCode()
				^ ssIsActive.GetHashCode()
				^ ssUpdateOn.GetHashCode()
				^ ssCreatedOn.GetHashCode()
				^ ssCreatedBy.GetHashCode()
				^ ssUpdateBy.GetHashCode()
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

		public ENFaQEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssid = 0;
			_ssQuestion = "";
			_ssAnswer = "";
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0L;
			_ssUpdateBy = 0L;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssQuestion", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssQuestion' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssQuestion = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssAnswer", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssAnswer' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssAnswer = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssIsActive", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIsActive' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIsActive = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedBy = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateBy = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENFaQEntityRecord Duplicate() {
			ENFaQEntityRecord t;
			t._ssid = this._ssid;
			t._ssQuestion = this._ssQuestion;
			t._ssAnswer = this._ssAnswer;
			t._ssIsActive = this._ssIsActive;
			t._ssUpdateOn = this._ssUpdateOn;
			t._ssCreatedOn = this._ssCreatedOn;
			t._ssCreatedBy = this._ssCreatedBy;
			t._ssUpdateBy = this._ssUpdateBy;
			t.ChangedAttributes = new BitArray(8);
			t.OptimizedAttributes = new BitArray(8);
			for (int i = 0; i < 8; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".id")) VarValue.AppendAttribute(recordElem, "id", ssid, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Question")) VarValue.AppendAttribute(recordElem, "Question", ssQuestion, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Question");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Answer")) VarValue.AppendAttribute(recordElem, "Answer", ssAnswer, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Answer");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsActive")) VarValue.AppendAttribute(recordElem, "IsActive", ssIsActive, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsActive");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateOn")) VarValue.AppendAttribute(recordElem, "UpdateOn", ssUpdateOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedOn")) VarValue.AppendAttribute(recordElem, "CreatedOn", ssCreatedOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedBy")) VarValue.AppendAttribute(recordElem, "CreatedBy", ssCreatedBy, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedBy");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateBy")) VarValue.AppendAttribute(recordElem, "UpdateBy", ssUpdateBy, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateBy");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
			} else if (head == "question") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Question")) variable.Value = ssQuestion; else variable.Optimized = true;
			} else if (head == "answer") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Answer")) variable.Value = ssAnswer; else variable.Optimized = true;
			} else if (head == "isactive") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
			} else if (head == "updateon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateOn")) variable.Value = ssUpdateOn; else variable.Optimized = true;
			} else if (head == "createdon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
			} else if (head == "createdby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
			} else if (head == "updateby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateBy")) variable.Value = ssUpdateBy; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdQuestion)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdAnswer)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdIsActive)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateOn)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdCreatedOn)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdCreatedBy)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdUpdateBy)) {
				return ChangedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdQuestion)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdAnswer)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdIsActive)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateOn)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdCreatedOn)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdCreatedBy)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdUpdateBy)) {
				return OptimizedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == IdQuestion) {
				return ssQuestion;
			} else if (key == IdAnswer) {
				return ssAnswer;
			} else if (key == IdIsActive) {
				return ssIsActive;
			} else if (key == IdUpdateOn) {
				return ssUpdateOn;
			} else if (key == IdCreatedOn) {
				return ssCreatedOn;
			} else if (key == IdCreatedBy) {
				return ssCreatedBy;
			} else if (key == IdUpdateBy) {
				return ssUpdateBy;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(8);
			OptimizedAttributes = new BitArray(8);
			if (other == null) return;
			ssid = (int) other.AttributeGet(Idid);
			ChangedAttributes[0] = other.ChangedAttributeGet(Idid);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(Idid);
			ssQuestion = (string) other.AttributeGet(IdQuestion);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdQuestion);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdQuestion);
			ssAnswer = (string) other.AttributeGet(IdAnswer);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdAnswer);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdAnswer);
			ssIsActive = (bool) other.AttributeGet(IdIsActive);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdIsActive);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsActive);
			ssUpdateOn = (DateTime) other.AttributeGet(IdUpdateOn);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateOn);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateOn);
			ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedOn);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedOn);
			ssCreatedBy = (long) other.AttributeGet(IdCreatedBy);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedBy);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedBy);
			ssUpdateBy = (long) other.AttributeGet(IdUpdateBy);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdUpdateBy);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdUpdateBy);
		}
		public bool IsDefault() {
			ENFaQEntityRecord defaultStruct = new ENFaQEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssQuestion != defaultStruct.ssQuestion) return false;
			if (this.ssAnswer != defaultStruct.ssAnswer) return false;
			if (this.ssIsActive != defaultStruct.ssIsActive) return false;
			if (this.ssUpdateOn != defaultStruct.ssUpdateOn) return false;
			if (this.ssCreatedOn != defaultStruct.ssCreatedOn) return false;
			if (this.ssCreatedBy != defaultStruct.ssCreatedBy) return false;
			if (this.ssUpdateBy != defaultStruct.ssUpdateBy) return false;
			return true;
		}
	} // ENFaQEntityRecord

	public class ENNewsEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "ef158d7b-f666-4ddd-8da2-8958459111da", "262bc89e-d067-4ade-89fd-432318a003fe", "News", "[Outsystems].[dbo].[New]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Outsystems].[dbo].[New]"; 
					}
				} catch {
					return "[Outsystems].[dbo].[New]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENNewsEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "title", "Title"
			}
			, { "content", "Content"
			}
			, { "urlphotonews", "URLPhotoNews"
			}
			, { "urlnews", "URLNews"
			}
			, { "isactive", "IsActive"
			}
			, { "updateon", "UpdateOn"
			}
			, { "createdon", "CreatedOn"
			}
			, { "createdby", "CreatedBy"
			}
			, { "updateby", "UpdateBy"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENNewsEntityConfiguration.GetPhysicalTableName();
		}
	} // ENNewsEntity

	/// <summary>
	/// Entity <code>ENNewsEntityRecord</code> that represents the Service Studio entity <code>News</code>
	///  <p> Description: Part of the Home in the carrossel, Inform the employee of the last news , have
	/// a title and a small description and a url of the complete news</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("News", "nsgrJmfQ3kqJ_UMjGKAD_g", "e40V72b23U2NoolYRZER2g", 0, "[Outsystems].[dbo].[New]", null)]
	[Serializable()]
	public partial struct ENNewsEntityRecord: ISerializable, ITypedRecord<ENNewsEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*rGZO0tINT0iO4Bc6+rY7oQ");
		internal static readonly GlobalObjectKey IdTitle = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*yK_iDTOH30yupUZ5ffZyDA");
		internal static readonly GlobalObjectKey IdContent = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*AgAYbga3LEGKnHiaAOPoSg");
		internal static readonly GlobalObjectKey IdURLPhotoNews = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*u4FqrSK7_0ixEF6S2fcRTA");
		internal static readonly GlobalObjectKey IdURLNews = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*dAOt1lRAM0un1zYKA7GJ2g");
		internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*CTb8QjnnwUGJhKCUK4ABJw");
		internal static readonly GlobalObjectKey IdUpdateOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*cggPNcfy3US6zWsN3yhlEg");
		internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*D2N2EErfkECNzkWCx8623g");
		internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*9j0mkKTzZ0KFrjLEN40T6A");
		internal static readonly GlobalObjectKey IdUpdateBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*v4CnqQw1O02q_QRBrQn7zg");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("id", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("id")]
		private int _ssid;
		public int ssid {
			get {
				return _ssid;
			}
			set {
				if ((_ssid!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(10, true);
					_ssid = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Title", 150, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Title")]
		private string _ssTitle;
		public string ssTitle {
			get {
				return _ssTitle;
			}
			set {
				if ((_ssTitle!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssTitle = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Content", 1000, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Content")]
		private string _ssContent;
		public string ssContent {
			get {
				return _ssContent;
			}
			set {
				if ((_ssContent!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssContent = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("URLPhotoNews", 250, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("URLPhotoNews")]
		private string _ssURLPhotoNews;
		public string ssURLPhotoNews {
			get {
				return _ssURLPhotoNews;
			}
			set {
				if ((_ssURLPhotoNews!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssURLPhotoNews = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("URLNews", 250, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("URLNews")]
		private string _ssURLNews;
		public string ssURLNews {
			get {
				return _ssURLNews;
			}
			set {
				if ((_ssURLNews!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssURLNews = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("IsActive", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("IsActive")]
		private bool _ssIsActive;
		public bool ssIsActive {
			get {
				return _ssIsActive;
			}
			set {
				if ((_ssIsActive!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssIsActive = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateOn")]
		private DateTime _ssUpdateOn;
		public DateTime ssUpdateOn {
			get {
				return _ssUpdateOn;
			}
			set {
				if ((_ssUpdateOn!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssUpdateOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedOn")]
		private DateTime _ssCreatedOn;
		public DateTime ssCreatedOn {
			get {
				return _ssCreatedOn;
			}
			set {
				if ((_ssCreatedOn!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssCreatedOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedBy", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedBy")]
		private long _ssCreatedBy;
		public long ssCreatedBy {
			get {
				return _ssCreatedBy;
			}
			set {
				if ((_ssCreatedBy!=value) || OptimizedAttributes[8]) {
					ChangedAttributes[8] = true;
					_ssCreatedBy = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateBy", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateBy")]
		private long _ssUpdateBy;
		public long ssUpdateBy {
			get {
				return _ssUpdateBy;
			}
			set {
				if ((_ssUpdateBy!=value) || OptimizedAttributes[9]) {
					ChangedAttributes[9] = true;
					_ssUpdateBy = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENNewsEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(10, true);
			OptimizedAttributes = new BitArray(10, false);
			_ssid = 0;
			_ssTitle = "";
			_ssContent = "";
			_ssURLPhotoNews = "";
			_ssURLNews = "";
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0L;
			_ssUpdateBy = 0L;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssid = r.ReadInteger(index++, "News.id", 0);
			ssTitle = r.ReadText(index++, "News.Title", "");
			ssContent = r.ReadText(index++, "News.Content", "");
			ssURLPhotoNews = r.ReadText(index++, "News.URLPhotoNews", "");
			ssURLNews = r.ReadText(index++, "News.URLNews", "");
			ssIsActive = r.ReadBoolean(index++, "News.IsActive", false);
			ssUpdateOn = r.ReadDateTime(index++, "News.UpdateOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedOn = r.ReadDateTime(index++, "News.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedBy = r.ReadLongInteger(index++, "News.CreatedBy", 0L);
			ssUpdateBy = r.ReadLongInteger(index++, "News.UpdateBy", 0L);
			ChangedAttributes = new BitArray(10, false);
			OptimizedAttributes = new BitArray(10, false);
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
		public void ReadIM(ENNewsEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENNewsEntityRecord a, ENNewsEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssTitle != b.ssTitle) return false;
			if (a.ssContent != b.ssContent) return false;
			if (a.ssURLPhotoNews != b.ssURLPhotoNews) return false;
			if (a.ssURLNews != b.ssURLNews) return false;
			if (a.ssIsActive != b.ssIsActive) return false;
			if (a.ssUpdateOn != b.ssUpdateOn) return false;
			if (a.ssCreatedOn != b.ssCreatedOn) return false;
			if (a.ssCreatedBy != b.ssCreatedBy) return false;
			if (a.ssUpdateBy != b.ssUpdateBy) return false;
			return true;
		}

		public static bool operator != (ENNewsEntityRecord a, ENNewsEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENNewsEntityRecord)) return false;
			return (this == (ENNewsEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssTitle.GetHashCode()
				^ ssContent.GetHashCode()
				^ ssURLPhotoNews.GetHashCode()
				^ ssURLNews.GetHashCode()
				^ ssIsActive.GetHashCode()
				^ ssUpdateOn.GetHashCode()
				^ ssCreatedOn.GetHashCode()
				^ ssCreatedBy.GetHashCode()
				^ ssUpdateBy.GetHashCode()
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

		public ENNewsEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(10, true);
			OptimizedAttributes = new BitArray(10, false);
			_ssid = 0;
			_ssTitle = "";
			_ssContent = "";
			_ssURLPhotoNews = "";
			_ssURLNews = "";
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0L;
			_ssUpdateBy = 0L;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssTitle", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssTitle' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssTitle = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssContent", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssContent' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssContent = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssURLPhotoNews", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssURLPhotoNews' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssURLPhotoNews = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssURLNews", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssURLNews' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssURLNews = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssIsActive", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIsActive' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIsActive = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedBy = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateBy = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENNewsEntityRecord Duplicate() {
			ENNewsEntityRecord t;
			t._ssid = this._ssid;
			t._ssTitle = this._ssTitle;
			t._ssContent = this._ssContent;
			t._ssURLPhotoNews = this._ssURLPhotoNews;
			t._ssURLNews = this._ssURLNews;
			t._ssIsActive = this._ssIsActive;
			t._ssUpdateOn = this._ssUpdateOn;
			t._ssCreatedOn = this._ssCreatedOn;
			t._ssCreatedBy = this._ssCreatedBy;
			t._ssUpdateBy = this._ssUpdateBy;
			t.ChangedAttributes = new BitArray(10);
			t.OptimizedAttributes = new BitArray(10);
			for (int i = 0; i < 10; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".id")) VarValue.AppendAttribute(recordElem, "id", ssid, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Title")) VarValue.AppendAttribute(recordElem, "Title", ssTitle, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Title");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Content")) VarValue.AppendAttribute(recordElem, "Content", ssContent, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Content");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".URLPhotoNews")) VarValue.AppendAttribute(recordElem, "URLPhotoNews", ssURLPhotoNews, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "URLPhotoNews");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".URLNews")) VarValue.AppendAttribute(recordElem, "URLNews", ssURLNews, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "URLNews");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsActive")) VarValue.AppendAttribute(recordElem, "IsActive", ssIsActive, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsActive");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateOn")) VarValue.AppendAttribute(recordElem, "UpdateOn", ssUpdateOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedOn")) VarValue.AppendAttribute(recordElem, "CreatedOn", ssCreatedOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedBy")) VarValue.AppendAttribute(recordElem, "CreatedBy", ssCreatedBy, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedBy");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateBy")) VarValue.AppendAttribute(recordElem, "UpdateBy", ssUpdateBy, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateBy");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
			} else if (head == "title") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Title")) variable.Value = ssTitle; else variable.Optimized = true;
			} else if (head == "content") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Content")) variable.Value = ssContent; else variable.Optimized = true;
			} else if (head == "urlphotonews") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".URLPhotoNews")) variable.Value = ssURLPhotoNews; else variable.Optimized = true;
			} else if (head == "urlnews") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".URLNews")) variable.Value = ssURLNews; else variable.Optimized = true;
			} else if (head == "isactive") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
			} else if (head == "updateon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateOn")) variable.Value = ssUpdateOn; else variable.Optimized = true;
			} else if (head == "createdon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
			} else if (head == "createdby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
			} else if (head == "updateby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateBy")) variable.Value = ssUpdateBy; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdTitle)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdContent)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdURLPhotoNews)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdURLNews)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdIsActive)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdUpdateOn)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdCreatedOn)) {
				return ChangedAttributes[7];
			} else if (key.Equals(IdCreatedBy)) {
				return ChangedAttributes[8];
			} else if (key.Equals(IdUpdateBy)) {
				return ChangedAttributes[9];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdTitle)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdContent)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdURLPhotoNews)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdURLNews)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdIsActive)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdUpdateOn)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdCreatedOn)) {
				return OptimizedAttributes[7];
			} else if (key.Equals(IdCreatedBy)) {
				return OptimizedAttributes[8];
			} else if (key.Equals(IdUpdateBy)) {
				return OptimizedAttributes[9];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == IdTitle) {
				return ssTitle;
			} else if (key == IdContent) {
				return ssContent;
			} else if (key == IdURLPhotoNews) {
				return ssURLPhotoNews;
			} else if (key == IdURLNews) {
				return ssURLNews;
			} else if (key == IdIsActive) {
				return ssIsActive;
			} else if (key == IdUpdateOn) {
				return ssUpdateOn;
			} else if (key == IdCreatedOn) {
				return ssCreatedOn;
			} else if (key == IdCreatedBy) {
				return ssCreatedBy;
			} else if (key == IdUpdateBy) {
				return ssUpdateBy;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(10);
			OptimizedAttributes = new BitArray(10);
			if (other == null) return;
			ssid = (int) other.AttributeGet(Idid);
			ChangedAttributes[0] = other.ChangedAttributeGet(Idid);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(Idid);
			ssTitle = (string) other.AttributeGet(IdTitle);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdTitle);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdTitle);
			ssContent = (string) other.AttributeGet(IdContent);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdContent);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdContent);
			ssURLPhotoNews = (string) other.AttributeGet(IdURLPhotoNews);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdURLPhotoNews);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdURLPhotoNews);
			ssURLNews = (string) other.AttributeGet(IdURLNews);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdURLNews);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdURLNews);
			ssIsActive = (bool) other.AttributeGet(IdIsActive);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdIsActive);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIsActive);
			ssUpdateOn = (DateTime) other.AttributeGet(IdUpdateOn);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdUpdateOn);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUpdateOn);
			ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdCreatedOn);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCreatedOn);
			ssCreatedBy = (long) other.AttributeGet(IdCreatedBy);
			ChangedAttributes[8] = other.ChangedAttributeGet(IdCreatedBy);
			OptimizedAttributes[8] = other.OptimizedAttributeGet(IdCreatedBy);
			ssUpdateBy = (long) other.AttributeGet(IdUpdateBy);
			ChangedAttributes[9] = other.ChangedAttributeGet(IdUpdateBy);
			OptimizedAttributes[9] = other.OptimizedAttributeGet(IdUpdateBy);
		}
		public bool IsDefault() {
			ENNewsEntityRecord defaultStruct = new ENNewsEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssTitle != defaultStruct.ssTitle) return false;
			if (this.ssContent != defaultStruct.ssContent) return false;
			if (this.ssURLPhotoNews != defaultStruct.ssURLPhotoNews) return false;
			if (this.ssURLNews != defaultStruct.ssURLNews) return false;
			if (this.ssIsActive != defaultStruct.ssIsActive) return false;
			if (this.ssUpdateOn != defaultStruct.ssUpdateOn) return false;
			if (this.ssCreatedOn != defaultStruct.ssCreatedOn) return false;
			if (this.ssCreatedBy != defaultStruct.ssCreatedBy) return false;
			if (this.ssUpdateBy != defaultStruct.ssUpdateBy) return false;
			return true;
		}
	} // ENNewsEntityRecord

	public class ENBranchEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "ef158d7b-f666-4ddd-8da2-8958459111da", "d6f27216-3f64-4f69-88d7-510d63a60d64", "Branch", "[Outsystems].[dbo].[Branch]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Outsystems].[dbo].[Branch]"; 
					}
				} catch {
					return "[Outsystems].[dbo].[Branch]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENBranchEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "label", "Label"
			}
			, { "order", "Order"
			}
			, { "is_active", "Is_Active"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENBranchEntityConfiguration.GetPhysicalTableName();
		}
	} // ENBranchEntity

	/// <summary>
	/// Entity <code>ENBranchEntityRecord</code> that represents the Service Studio entity
	///  <code>Branch</code> <p> Description: Static entitites</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Branch", "FnLy1mQ_aU+I11ENY6YNZA", "e40V72b23U2NoolYRZER2g", 0, "[Outsystems].[dbo].[Branch]", null)]
	[Serializable()]
	public partial struct ENBranchEntityRecord: ISerializable, ITypedRecord<ENBranchEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*D5V1pa_0h02KrZs4l6KXiA");
		internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*shB9jELYlEmW_qibf6SqmQ");
		internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*YizwmdfhKU2QCWBjXmzuXQ");
		internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*ZkvV8WBC206vc4yiHgkfDQ");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("id", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("id")]
		private int _ssid;
		public int ssid {
			get {
				return _ssid;
			}
			set {
				if ((_ssid!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(4, true);
					_ssid = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Label", 150, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Label")]
		private string _ssLabel;
		public string ssLabel {
			get {
				return _ssLabel;
			}
			set {
				if ((_ssLabel!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssLabel = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Order", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Order")]
		private int _ssOrder;
		public int ssOrder {
			get {
				return _ssOrder;
			}
			set {
				if ((_ssOrder!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssOrder = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Is_Active", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Is_Active")]
		private bool _ssIs_Active;
		public bool ssIs_Active {
			get {
				return _ssIs_Active;
			}
			set {
				if ((_ssIs_Active!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssIs_Active = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENBranchEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssid = 0;
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = true;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssid = r.ReadInteger(index++, "Branch.id", 0);
			ssLabel = r.ReadText(index++, "Branch.Label", "");
			ssOrder = r.ReadInteger(index++, "Branch.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "Branch.Is_Active", false);
			ChangedAttributes = new BitArray(4, false);
			OptimizedAttributes = new BitArray(4, false);
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
		public void ReadIM(ENBranchEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENBranchEntityRecord a, ENBranchEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENBranchEntityRecord a, ENBranchEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENBranchEntityRecord)) return false;
			return (this == (ENBranchEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssLabel.GetHashCode()
				^ ssOrder.GetHashCode()
				^ ssIs_Active.GetHashCode()
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

		public ENBranchEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssid = 0;
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = true;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssLabel", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssLabel' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssLabel = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssOrder", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssOrder' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssOrder = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssIs_Active", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIs_Active' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIs_Active = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENBranchEntityRecord Duplicate() {
			ENBranchEntityRecord t;
			t._ssid = this._ssid;
			t._ssLabel = this._ssLabel;
			t._ssOrder = this._ssOrder;
			t._ssIs_Active = this._ssIs_Active;
			t.ChangedAttributes = new BitArray(4);
			t.OptimizedAttributes = new BitArray(4);
			for (int i = 0; i < 4; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".id")) VarValue.AppendAttribute(recordElem, "id", ssid, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Label")) VarValue.AppendAttribute(recordElem, "Label", ssLabel, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Label");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Order")) VarValue.AppendAttribute(recordElem, "Order", ssOrder, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "Order");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Is_Active")) VarValue.AppendAttribute(recordElem, "Is_Active", ssIs_Active, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "Is_Active");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
			} else if (head == "label") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
			} else if (head == "order") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
			} else if (head == "is_active") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdLabel)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdOrder)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdIs_Active)) {
				return ChangedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdLabel)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdOrder)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdIs_Active)) {
				return OptimizedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == IdLabel) {
				return ssLabel;
			} else if (key == IdOrder) {
				return ssOrder;
			} else if (key == IdIs_Active) {
				return ssIs_Active;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(4);
			OptimizedAttributes = new BitArray(4);
			if (other == null) return;
			ssid = (int) other.AttributeGet(Idid);
			ChangedAttributes[0] = other.ChangedAttributeGet(Idid);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(Idid);
			ssLabel = (string) other.AttributeGet(IdLabel);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
			ssOrder = (int) other.AttributeGet(IdOrder);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdOrder);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrder);
			ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdIs_Active);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIs_Active);
		}
		public bool IsDefault() {
			ENBranchEntityRecord defaultStruct = new ENBranchEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssLabel != defaultStruct.ssLabel) return false;
			if (this.ssOrder != defaultStruct.ssOrder) return false;
			if (this.ssIs_Active != defaultStruct.ssIs_Active) return false;
			return true;
		}
	} // ENBranchEntityRecord

	public class ENPayrollPDFEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "ef158d7b-f666-4ddd-8da2-8958459111da", "fca9470f-0baa-4209-a3d8-6cea1ba8f050", "PayrollPDF", "[Outsystems].[dbo].[PayrollPDF]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Outsystems].[dbo].[PayrollPDF]"; 
					}
				} catch {
					return "[Outsystems].[dbo].[PayrollPDF]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENPayrollPDFEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "employeeid", "EmployeeId"
			}
			, { "payrolid", "PayrolId"
			}
			, { "isactive", "IsActive"
			}
			, { "updateon", "UpdateOn"
			}
			, { "createdon", "CreatedOn"
			}
			, { "createdby", "CreatedBy"
			}
			, { "updateby", "UpdateBy"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENPayrollPDFEntityConfiguration.GetPhysicalTableName();
		}
	} // ENPayrollPDFEntity

	/// <summary>
	/// Entity <code>ENPayrollPDFEntityRecord</code> that represents the Service Studio entity
	///  <code>PayrollPDF</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("PayrollPDF", "D0ep_KoLCUKj2GzqG6jwUA", "e40V72b23U2NoolYRZER2g", 0, "[Outsystems].[dbo].[PayrollPDF]", null)]
	[Serializable()]
	public partial struct ENPayrollPDFEntityRecord: ISerializable, ITypedRecord<ENPayrollPDFEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*fxKhN7kajUyNsTzrggrDvw");
		internal static readonly GlobalObjectKey IdEmployeeId = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*SgJwyuVqnEKj7+TBw_K13w");
		internal static readonly GlobalObjectKey IdPayrolId = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*4hYjxOg4dU2fii_X+Fx39A");
		internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*0y5VSdd2tUqRQJ26jJzG7g");
		internal static readonly GlobalObjectKey IdUpdateOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*fl1lGcFIFUidSRv3Vf_OBg");
		internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*pybF1i2MOUusz_U5Uf8NPA");
		internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*CFf1FxMYyEeJywRdioE4mg");
		internal static readonly GlobalObjectKey IdUpdateBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*jmXna4i7b0SSfwh3Yd9yvg");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("id", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("id")]
		private int _ssid;
		public int ssid {
			get {
				return _ssid;
			}
			set {
				if ((_ssid!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(8, true);
					_ssid = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("EmployeeId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("EmployeeId")]
		private int _ssEmployeeId;
		public int ssEmployeeId {
			get {
				return _ssEmployeeId;
			}
			set {
				if ((_ssEmployeeId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssEmployeeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PayrolId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("PayrolId")]
		private int _ssPayrolId;
		public int ssPayrolId {
			get {
				return _ssPayrolId;
			}
			set {
				if ((_ssPayrolId!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssPayrolId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("IsActive", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("IsActive")]
		private bool _ssIsActive;
		public bool ssIsActive {
			get {
				return _ssIsActive;
			}
			set {
				if ((_ssIsActive!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssIsActive = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateOn")]
		private DateTime _ssUpdateOn;
		public DateTime ssUpdateOn {
			get {
				return _ssUpdateOn;
			}
			set {
				if ((_ssUpdateOn!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedOn")]
		private DateTime _ssCreatedOn;
		public DateTime ssCreatedOn {
			get {
				return _ssCreatedOn;
			}
			set {
				if ((_ssCreatedOn!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssCreatedOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedBy", 0, false, false, true, false)]
		[System.Xml.Serialization.XmlElement("CreatedBy")]
		private int _ssCreatedBy;
		public int ssCreatedBy {
			get {
				return _ssCreatedBy;
			}
			set {
				if ((_ssCreatedBy!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssCreatedBy = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateBy", 0, false, false, true, false)]
		[System.Xml.Serialization.XmlElement("UpdateBy")]
		private int _ssUpdateBy;
		public int ssUpdateBy {
			get {
				return _ssUpdateBy;
			}
			set {
				if ((_ssUpdateBy!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssUpdateBy = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENPayrollPDFEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssid = 0;
			_ssEmployeeId = 0;
			_ssPayrolId = 0;
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0;
			_ssUpdateBy = 0;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssid = r.ReadInteger(index++, "PayrollPDF.id", 0);
			ssEmployeeId = r.ReadEntityReference(index++, "PayrollPDF.EmployeeId", 0);
			ssPayrolId = r.ReadEntityReference(index++, "PayrollPDF.PayrolId", 0);
			ssIsActive = r.ReadBoolean(index++, "PayrollPDF.IsActive", false);
			ssUpdateOn = r.ReadDateTime(index++, "PayrollPDF.UpdateOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedOn = r.ReadDateTime(index++, "PayrollPDF.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedBy = r.ReadEntityReference(index++, "PayrollPDF.CreatedBy", 0);
			ssUpdateBy = r.ReadEntityReference(index++, "PayrollPDF.UpdateBy", 0);
			ChangedAttributes = new BitArray(8, false);
			OptimizedAttributes = new BitArray(8, false);
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
		public void ReadIM(ENPayrollPDFEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENPayrollPDFEntityRecord a, ENPayrollPDFEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssEmployeeId != b.ssEmployeeId) return false;
			if (a.ssPayrolId != b.ssPayrolId) return false;
			if (a.ssIsActive != b.ssIsActive) return false;
			if (a.ssUpdateOn != b.ssUpdateOn) return false;
			if (a.ssCreatedOn != b.ssCreatedOn) return false;
			if (a.ssCreatedBy != b.ssCreatedBy) return false;
			if (a.ssUpdateBy != b.ssUpdateBy) return false;
			return true;
		}

		public static bool operator != (ENPayrollPDFEntityRecord a, ENPayrollPDFEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENPayrollPDFEntityRecord)) return false;
			return (this == (ENPayrollPDFEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssEmployeeId.GetHashCode()
				^ ssPayrolId.GetHashCode()
				^ ssIsActive.GetHashCode()
				^ ssUpdateOn.GetHashCode()
				^ ssCreatedOn.GetHashCode()
				^ ssCreatedBy.GetHashCode()
				^ ssUpdateBy.GetHashCode()
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

		public ENPayrollPDFEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssid = 0;
			_ssEmployeeId = 0;
			_ssPayrolId = 0;
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0;
			_ssUpdateBy = 0;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssEmployeeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssEmployeeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssEmployeeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssPayrolId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssPayrolId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssPayrolId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssIsActive", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIsActive' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIsActive = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedBy = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateBy = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENPayrollPDFEntityRecord Duplicate() {
			ENPayrollPDFEntityRecord t;
			t._ssid = this._ssid;
			t._ssEmployeeId = this._ssEmployeeId;
			t._ssPayrolId = this._ssPayrolId;
			t._ssIsActive = this._ssIsActive;
			t._ssUpdateOn = this._ssUpdateOn;
			t._ssCreatedOn = this._ssCreatedOn;
			t._ssCreatedBy = this._ssCreatedBy;
			t._ssUpdateBy = this._ssUpdateBy;
			t.ChangedAttributes = new BitArray(8);
			t.OptimizedAttributes = new BitArray(8);
			for (int i = 0; i < 8; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".id")) VarValue.AppendAttribute(recordElem, "id", ssid, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".EmployeeId")) VarValue.AppendAttribute(recordElem, "EmployeeId", ssEmployeeId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "EmployeeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".PayrolId")) VarValue.AppendAttribute(recordElem, "PayrolId", ssPayrolId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "PayrolId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsActive")) VarValue.AppendAttribute(recordElem, "IsActive", ssIsActive, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsActive");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateOn")) VarValue.AppendAttribute(recordElem, "UpdateOn", ssUpdateOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedOn")) VarValue.AppendAttribute(recordElem, "CreatedOn", ssCreatedOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedBy")) VarValue.AppendAttribute(recordElem, "CreatedBy", ssCreatedBy, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedBy");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateBy")) VarValue.AppendAttribute(recordElem, "UpdateBy", ssUpdateBy, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateBy");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
			} else if (head == "employeeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EmployeeId")) variable.Value = ssEmployeeId; else variable.Optimized = true;
			} else if (head == "payrolid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".PayrolId")) variable.Value = ssPayrolId; else variable.Optimized = true;
			} else if (head == "isactive") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
			} else if (head == "updateon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateOn")) variable.Value = ssUpdateOn; else variable.Optimized = true;
			} else if (head == "createdon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
			} else if (head == "createdby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
			} else if (head == "updateby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateBy")) variable.Value = ssUpdateBy; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdEmployeeId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdPayrolId)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdIsActive)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateOn)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdCreatedOn)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdCreatedBy)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdUpdateBy)) {
				return ChangedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdEmployeeId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdPayrolId)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdIsActive)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateOn)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdCreatedOn)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdCreatedBy)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdUpdateBy)) {
				return OptimizedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == IdEmployeeId) {
				return ssEmployeeId;
			} else if (key == IdPayrolId) {
				return ssPayrolId;
			} else if (key == IdIsActive) {
				return ssIsActive;
			} else if (key == IdUpdateOn) {
				return ssUpdateOn;
			} else if (key == IdCreatedOn) {
				return ssCreatedOn;
			} else if (key == IdCreatedBy) {
				return ssCreatedBy;
			} else if (key == IdUpdateBy) {
				return ssUpdateBy;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(8);
			OptimizedAttributes = new BitArray(8);
			if (other == null) return;
			ssid = (int) other.AttributeGet(Idid);
			ChangedAttributes[0] = other.ChangedAttributeGet(Idid);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(Idid);
			ssEmployeeId = (int) other.AttributeGet(IdEmployeeId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdEmployeeId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdEmployeeId);
			ssPayrolId = (int) other.AttributeGet(IdPayrolId);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdPayrolId);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdPayrolId);
			ssIsActive = (bool) other.AttributeGet(IdIsActive);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdIsActive);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsActive);
			ssUpdateOn = (DateTime) other.AttributeGet(IdUpdateOn);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateOn);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateOn);
			ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedOn);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedOn);
			ssCreatedBy = (int) other.AttributeGet(IdCreatedBy);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedBy);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedBy);
			ssUpdateBy = (int) other.AttributeGet(IdUpdateBy);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdUpdateBy);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdUpdateBy);
		}
		public bool IsDefault() {
			ENPayrollPDFEntityRecord defaultStruct = new ENPayrollPDFEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssEmployeeId != defaultStruct.ssEmployeeId) return false;
			if (this.ssPayrolId != defaultStruct.ssPayrolId) return false;
			if (this.ssIsActive != defaultStruct.ssIsActive) return false;
			if (this.ssUpdateOn != defaultStruct.ssUpdateOn) return false;
			if (this.ssCreatedOn != defaultStruct.ssCreatedOn) return false;
			if (this.ssCreatedBy != defaultStruct.ssCreatedBy) return false;
			if (this.ssUpdateBy != defaultStruct.ssUpdateBy) return false;
			return true;
		}
	} // ENPayrollPDFEntityRecord

	public class ENTimeSheetPDFEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "ef158d7b-f666-4ddd-8da2-8958459111da", "785fb16b-322f-40a2-aac5-6b1c457bc506", "TimeSheetPDF", "[Outsystems].[dbo].[TimeSheetPDF]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Outsystems].[dbo].[TimeSheetPDF]"; 
					}
				} catch {
					return "[Outsystems].[dbo].[TimeSheetPDF]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENTimeSheetPDFEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "employeeid", "EmployeeId"
			}
			, { "timesheetid", "TimeSheetId"
			}
			, { "isactive", "IsActive"
			}
			, { "updateon", "UpdateOn"
			}
			, { "createdon", "CreatedOn"
			}
			, { "createdby", "CreatedBy"
			}
			, { "updateby", "UpdateBy"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENTimeSheetPDFEntityConfiguration.GetPhysicalTableName();
		}
	} // ENTimeSheetPDFEntity

	/// <summary>
	/// Entity <code>ENTimeSheetPDFEntityRecord</code> that represents the Service Studio entity
	///  <code>TimeSheetPDF</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("TimeSheetPDF", "a7FfeC8yokCqxWscRXvFBg", "e40V72b23U2NoolYRZER2g", 0, "[Outsystems].[dbo].[TimeSheetPDF]", null)]
	[Serializable()]
	public partial struct ENTimeSheetPDFEntityRecord: ISerializable, ITypedRecord<ENTimeSheetPDFEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*Cm2+yITquEWNTcObf7ZH5w");
		internal static readonly GlobalObjectKey IdEmployeeId = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*Yv+M+pbeU0Ke03_KXH7FGA");
		internal static readonly GlobalObjectKey IdTimeSheetId = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*cNBzRVNmcEaa2fL4XjsDjg");
		internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*IpUZo2pKKE6Co_JUX27xgQ");
		internal static readonly GlobalObjectKey IdUpdateOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*el1n5F6yHEePXhIIKrIByQ");
		internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*ysQoYb_ndUa4ULlIQT6Gfw");
		internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*MkmwZQshekORM2ot19e7mQ");
		internal static readonly GlobalObjectKey IdUpdateBy = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*lb6qNg5drUSrqDWAUFbmCg");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("id", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("id")]
		private int _ssid;
		public int ssid {
			get {
				return _ssid;
			}
			set {
				if ((_ssid!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(8, true);
					_ssid = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("EmployeeId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("EmployeeId")]
		private int _ssEmployeeId;
		public int ssEmployeeId {
			get {
				return _ssEmployeeId;
			}
			set {
				if ((_ssEmployeeId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssEmployeeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("TimeSheetId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("TimeSheetId")]
		private int _ssTimeSheetId;
		public int ssTimeSheetId {
			get {
				return _ssTimeSheetId;
			}
			set {
				if ((_ssTimeSheetId!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssTimeSheetId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("IsActive", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("IsActive")]
		private bool _ssIsActive;
		public bool ssIsActive {
			get {
				return _ssIsActive;
			}
			set {
				if ((_ssIsActive!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssIsActive = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateOn")]
		private DateTime _ssUpdateOn;
		public DateTime ssUpdateOn {
			get {
				return _ssUpdateOn;
			}
			set {
				if ((_ssUpdateOn!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedOn", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("CreatedOn")]
		private DateTime _ssCreatedOn;
		public DateTime ssCreatedOn {
			get {
				return _ssCreatedOn;
			}
			set {
				if ((_ssCreatedOn!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssCreatedOn = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CreatedBy", 0, false, false, true, false)]
		[System.Xml.Serialization.XmlElement("CreatedBy")]
		private int _ssCreatedBy;
		public int ssCreatedBy {
			get {
				return _ssCreatedBy;
			}
			set {
				if ((_ssCreatedBy!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssCreatedBy = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateBy", 0, false, false, true, false)]
		[System.Xml.Serialization.XmlElement("UpdateBy")]
		private int _ssUpdateBy;
		public int ssUpdateBy {
			get {
				return _ssUpdateBy;
			}
			set {
				if ((_ssUpdateBy!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssUpdateBy = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENTimeSheetPDFEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssid = 0;
			_ssEmployeeId = 0;
			_ssTimeSheetId = 0;
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0;
			_ssUpdateBy = 0;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssid = r.ReadInteger(index++, "TimeSheetPDF.id", 0);
			ssEmployeeId = r.ReadEntityReference(index++, "TimeSheetPDF.EmployeeId", 0);
			ssTimeSheetId = r.ReadEntityReference(index++, "TimeSheetPDF.TimeSheetId", 0);
			ssIsActive = r.ReadBoolean(index++, "TimeSheetPDF.IsActive", false);
			ssUpdateOn = r.ReadDateTime(index++, "TimeSheetPDF.UpdateOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedOn = r.ReadDateTime(index++, "TimeSheetPDF.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0));
			ssCreatedBy = r.ReadEntityReference(index++, "TimeSheetPDF.CreatedBy", 0);
			ssUpdateBy = r.ReadEntityReference(index++, "TimeSheetPDF.UpdateBy", 0);
			ChangedAttributes = new BitArray(8, false);
			OptimizedAttributes = new BitArray(8, false);
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
		public void ReadIM(ENTimeSheetPDFEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENTimeSheetPDFEntityRecord a, ENTimeSheetPDFEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssEmployeeId != b.ssEmployeeId) return false;
			if (a.ssTimeSheetId != b.ssTimeSheetId) return false;
			if (a.ssIsActive != b.ssIsActive) return false;
			if (a.ssUpdateOn != b.ssUpdateOn) return false;
			if (a.ssCreatedOn != b.ssCreatedOn) return false;
			if (a.ssCreatedBy != b.ssCreatedBy) return false;
			if (a.ssUpdateBy != b.ssUpdateBy) return false;
			return true;
		}

		public static bool operator != (ENTimeSheetPDFEntityRecord a, ENTimeSheetPDFEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENTimeSheetPDFEntityRecord)) return false;
			return (this == (ENTimeSheetPDFEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssEmployeeId.GetHashCode()
				^ ssTimeSheetId.GetHashCode()
				^ ssIsActive.GetHashCode()
				^ ssUpdateOn.GetHashCode()
				^ ssCreatedOn.GetHashCode()
				^ ssCreatedBy.GetHashCode()
				^ ssUpdateBy.GetHashCode()
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

		public ENTimeSheetPDFEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssid = 0;
			_ssEmployeeId = 0;
			_ssTimeSheetId = 0;
			_ssIsActive = true;
			_ssUpdateOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssCreatedBy = 0;
			_ssUpdateBy = 0;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssEmployeeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssEmployeeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssEmployeeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssTimeSheetId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssTimeSheetId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssTimeSheetId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssIsActive", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIsActive' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIsActive = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedOn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedOn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedOn = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCreatedBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCreatedBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCreatedBy = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateBy", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateBy' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateBy = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENTimeSheetPDFEntityRecord Duplicate() {
			ENTimeSheetPDFEntityRecord t;
			t._ssid = this._ssid;
			t._ssEmployeeId = this._ssEmployeeId;
			t._ssTimeSheetId = this._ssTimeSheetId;
			t._ssIsActive = this._ssIsActive;
			t._ssUpdateOn = this._ssUpdateOn;
			t._ssCreatedOn = this._ssCreatedOn;
			t._ssCreatedBy = this._ssCreatedBy;
			t._ssUpdateBy = this._ssUpdateBy;
			t.ChangedAttributes = new BitArray(8);
			t.OptimizedAttributes = new BitArray(8);
			for (int i = 0; i < 8; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".id")) VarValue.AppendAttribute(recordElem, "id", ssid, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".EmployeeId")) VarValue.AppendAttribute(recordElem, "EmployeeId", ssEmployeeId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "EmployeeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".TimeSheetId")) VarValue.AppendAttribute(recordElem, "TimeSheetId", ssTimeSheetId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "TimeSheetId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsActive")) VarValue.AppendAttribute(recordElem, "IsActive", ssIsActive, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsActive");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateOn")) VarValue.AppendAttribute(recordElem, "UpdateOn", ssUpdateOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedOn")) VarValue.AppendAttribute(recordElem, "CreatedOn", ssCreatedOn, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedOn");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CreatedBy")) VarValue.AppendAttribute(recordElem, "CreatedBy", ssCreatedBy, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "CreatedBy");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateBy")) VarValue.AppendAttribute(recordElem, "UpdateBy", ssUpdateBy, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateBy");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
			} else if (head == "employeeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EmployeeId")) variable.Value = ssEmployeeId; else variable.Optimized = true;
			} else if (head == "timesheetid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TimeSheetId")) variable.Value = ssTimeSheetId; else variable.Optimized = true;
			} else if (head == "isactive") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
			} else if (head == "updateon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateOn")) variable.Value = ssUpdateOn; else variable.Optimized = true;
			} else if (head == "createdon") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
			} else if (head == "createdby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
			} else if (head == "updateby") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateBy")) variable.Value = ssUpdateBy; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdEmployeeId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdTimeSheetId)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdIsActive)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateOn)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdCreatedOn)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdCreatedBy)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdUpdateBy)) {
				return ChangedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdEmployeeId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdTimeSheetId)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdIsActive)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateOn)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdCreatedOn)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdCreatedBy)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdUpdateBy)) {
				return OptimizedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == IdEmployeeId) {
				return ssEmployeeId;
			} else if (key == IdTimeSheetId) {
				return ssTimeSheetId;
			} else if (key == IdIsActive) {
				return ssIsActive;
			} else if (key == IdUpdateOn) {
				return ssUpdateOn;
			} else if (key == IdCreatedOn) {
				return ssCreatedOn;
			} else if (key == IdCreatedBy) {
				return ssCreatedBy;
			} else if (key == IdUpdateBy) {
				return ssUpdateBy;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(8);
			OptimizedAttributes = new BitArray(8);
			if (other == null) return;
			ssid = (int) other.AttributeGet(Idid);
			ChangedAttributes[0] = other.ChangedAttributeGet(Idid);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(Idid);
			ssEmployeeId = (int) other.AttributeGet(IdEmployeeId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdEmployeeId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdEmployeeId);
			ssTimeSheetId = (int) other.AttributeGet(IdTimeSheetId);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdTimeSheetId);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdTimeSheetId);
			ssIsActive = (bool) other.AttributeGet(IdIsActive);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdIsActive);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsActive);
			ssUpdateOn = (DateTime) other.AttributeGet(IdUpdateOn);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateOn);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateOn);
			ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedOn);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedOn);
			ssCreatedBy = (int) other.AttributeGet(IdCreatedBy);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedBy);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedBy);
			ssUpdateBy = (int) other.AttributeGet(IdUpdateBy);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdUpdateBy);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdUpdateBy);
		}
		public bool IsDefault() {
			ENTimeSheetPDFEntityRecord defaultStruct = new ENTimeSheetPDFEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssEmployeeId != defaultStruct.ssEmployeeId) return false;
			if (this.ssTimeSheetId != defaultStruct.ssTimeSheetId) return false;
			if (this.ssIsActive != defaultStruct.ssIsActive) return false;
			if (this.ssUpdateOn != defaultStruct.ssUpdateOn) return false;
			if (this.ssCreatedOn != defaultStruct.ssCreatedOn) return false;
			if (this.ssCreatedBy != defaultStruct.ssCreatedBy) return false;
			if (this.ssUpdateBy != defaultStruct.ssUpdateBy) return false;
			return true;
		}
	} // ENTimeSheetPDFEntityRecord

	public class ENDepartmentEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "ef158d7b-f666-4ddd-8da2-8958459111da", "a1aa0448-8f3a-44c0-941d-0be073941537", "Department", "[Outsystems].[dbo].[Department]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Outsystems].[dbo].[Department]"; 
					}
				} catch {
					return "[Outsystems].[dbo].[Department]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENDepartmentEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "label", "Label"
			}
			, { "order", "Order"
			}
			, { "is_active", "Is_Active"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENDepartmentEntityConfiguration.GetPhysicalTableName();
		}
	} // ENDepartmentEntity

	/// <summary>
	/// Entity <code>ENDepartmentEntityRecord</code> that represents the Service Studio entity
	///  <code>Department</code> <p> Description: Static entitites</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Department", "SASqoTqPwESUHQvgc5QVNw", "e40V72b23U2NoolYRZER2g", 0, "[Outsystems].[dbo].[Department]", null)]
	[Serializable()]
	public partial struct ENDepartmentEntityRecord: ISerializable, ITypedRecord<ENDepartmentEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*aXWYPYif4E6M691t8+5zGw");
		internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*7or5cOj_LE+4ouhuXihbcw");
		internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*qG5st_GnYk+SKBwqV4a_sw");
		internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*KH5cSCIQr02qex1Rie9t2Q");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("id", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("id")]
		private int _ssid;
		public int ssid {
			get {
				return _ssid;
			}
			set {
				if ((_ssid!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(4, true);
					_ssid = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Label", 150, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Label")]
		private string _ssLabel;
		public string ssLabel {
			get {
				return _ssLabel;
			}
			set {
				if ((_ssLabel!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssLabel = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Order", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Order")]
		private int _ssOrder;
		public int ssOrder {
			get {
				return _ssOrder;
			}
			set {
				if ((_ssOrder!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssOrder = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Is_Active", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Is_Active")]
		private bool _ssIs_Active;
		public bool ssIs_Active {
			get {
				return _ssIs_Active;
			}
			set {
				if ((_ssIs_Active!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssIs_Active = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENDepartmentEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssid = 0;
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = true;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssid = r.ReadInteger(index++, "Department.id", 0);
			ssLabel = r.ReadText(index++, "Department.Label", "");
			ssOrder = r.ReadInteger(index++, "Department.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "Department.Is_Active", false);
			ChangedAttributes = new BitArray(4, false);
			OptimizedAttributes = new BitArray(4, false);
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
		public void ReadIM(ENDepartmentEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENDepartmentEntityRecord a, ENDepartmentEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENDepartmentEntityRecord a, ENDepartmentEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENDepartmentEntityRecord)) return false;
			return (this == (ENDepartmentEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssLabel.GetHashCode()
				^ ssOrder.GetHashCode()
				^ ssIs_Active.GetHashCode()
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

		public ENDepartmentEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssid = 0;
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = true;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssLabel", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssLabel' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssLabel = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssOrder", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssOrder' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssOrder = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssIs_Active", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIs_Active' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIs_Active = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENDepartmentEntityRecord Duplicate() {
			ENDepartmentEntityRecord t;
			t._ssid = this._ssid;
			t._ssLabel = this._ssLabel;
			t._ssOrder = this._ssOrder;
			t._ssIs_Active = this._ssIs_Active;
			t.ChangedAttributes = new BitArray(4);
			t.OptimizedAttributes = new BitArray(4);
			for (int i = 0; i < 4; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".id")) VarValue.AppendAttribute(recordElem, "id", ssid, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Label")) VarValue.AppendAttribute(recordElem, "Label", ssLabel, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Label");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Order")) VarValue.AppendAttribute(recordElem, "Order", ssOrder, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "Order");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Is_Active")) VarValue.AppendAttribute(recordElem, "Is_Active", ssIs_Active, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "Is_Active");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
			} else if (head == "label") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
			} else if (head == "order") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
			} else if (head == "is_active") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdLabel)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdOrder)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdIs_Active)) {
				return ChangedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdLabel)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdOrder)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdIs_Active)) {
				return OptimizedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == IdLabel) {
				return ssLabel;
			} else if (key == IdOrder) {
				return ssOrder;
			} else if (key == IdIs_Active) {
				return ssIs_Active;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(4);
			OptimizedAttributes = new BitArray(4);
			if (other == null) return;
			ssid = (int) other.AttributeGet(Idid);
			ChangedAttributes[0] = other.ChangedAttributeGet(Idid);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(Idid);
			ssLabel = (string) other.AttributeGet(IdLabel);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
			ssOrder = (int) other.AttributeGet(IdOrder);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdOrder);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrder);
			ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdIs_Active);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIs_Active);
		}
		public bool IsDefault() {
			ENDepartmentEntityRecord defaultStruct = new ENDepartmentEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssLabel != defaultStruct.ssLabel) return false;
			if (this.ssOrder != defaultStruct.ssOrder) return false;
			if (this.ssIs_Active != defaultStruct.ssIs_Active) return false;
			return true;
		}
	} // ENDepartmentEntityRecord

	public class ENJobTitleEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "ef158d7b-f666-4ddd-8da2-8958459111da", "d9ff4188-cf14-47b4-b3eb-1f21e3f976fe", "JobTitle", "[Outsystems].[dbo].[JobTitle]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Outsystems].[dbo].[JobTitle]"; 
					}
				} catch {
					return "[Outsystems].[dbo].[JobTitle]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENJobTitleEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "label", "Label"
			}
			, { "order", "Order"
			}
			, { "is_active", "Is_Active"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENJobTitleEntityConfiguration.GetPhysicalTableName();
		}
	} // ENJobTitleEntity

	/// <summary>
	/// Entity <code>ENJobTitleEntityRecord</code> that represents the Service Studio entity
	///  <code>JobTitle</code> <p> Description: Static entitites</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("JobTitle", "iEH_2RTPtEez6x8h4_l2_g", "e40V72b23U2NoolYRZER2g", 0, "[Outsystems].[dbo].[JobTitle]", null)]
	[Serializable()]
	public partial struct ENJobTitleEntityRecord: ISerializable, ITypedRecord<ENJobTitleEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*QUQ+TMQyEUiQIXjfZ7YzWA");
		internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*SbfmSX_YFkCi+T0xWyBN4g");
		internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*aEcBHBTlQUCrTquU9TXHtg");
		internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*WGD4J8DfJEqEVFyL41mahA");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("id", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("id")]
		private int _ssid;
		public int ssid {
			get {
				return _ssid;
			}
			set {
				if ((_ssid!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(4, true);
					_ssid = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Label", 150, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Label")]
		private string _ssLabel;
		public string ssLabel {
			get {
				return _ssLabel;
			}
			set {
				if ((_ssLabel!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssLabel = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Order", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Order")]
		private int _ssOrder;
		public int ssOrder {
			get {
				return _ssOrder;
			}
			set {
				if ((_ssOrder!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssOrder = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Is_Active", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Is_Active")]
		private bool _ssIs_Active;
		public bool ssIs_Active {
			get {
				return _ssIs_Active;
			}
			set {
				if ((_ssIs_Active!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssIs_Active = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENJobTitleEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssid = 0;
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = true;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssid = r.ReadInteger(index++, "JobTitle.id", 0);
			ssLabel = r.ReadText(index++, "JobTitle.Label", "");
			ssOrder = r.ReadInteger(index++, "JobTitle.Order", 0);
			ssIs_Active = r.ReadBoolean(index++, "JobTitle.Is_Active", false);
			ChangedAttributes = new BitArray(4, false);
			OptimizedAttributes = new BitArray(4, false);
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
		public void ReadIM(ENJobTitleEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENJobTitleEntityRecord a, ENJobTitleEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssOrder != b.ssOrder) return false;
			if (a.ssIs_Active != b.ssIs_Active) return false;
			return true;
		}

		public static bool operator != (ENJobTitleEntityRecord a, ENJobTitleEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENJobTitleEntityRecord)) return false;
			return (this == (ENJobTitleEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssLabel.GetHashCode()
				^ ssOrder.GetHashCode()
				^ ssIs_Active.GetHashCode()
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

		public ENJobTitleEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssid = 0;
			_ssLabel = "";
			_ssOrder = 0;
			_ssIs_Active = true;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssLabel", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssLabel' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssLabel = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssOrder", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssOrder' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssOrder = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssIs_Active", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIs_Active' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIs_Active = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENJobTitleEntityRecord Duplicate() {
			ENJobTitleEntityRecord t;
			t._ssid = this._ssid;
			t._ssLabel = this._ssLabel;
			t._ssOrder = this._ssOrder;
			t._ssIs_Active = this._ssIs_Active;
			t.ChangedAttributes = new BitArray(4);
			t.OptimizedAttributes = new BitArray(4);
			for (int i = 0; i < 4; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".id")) VarValue.AppendAttribute(recordElem, "id", ssid, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Label")) VarValue.AppendAttribute(recordElem, "Label", ssLabel, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Label");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Order")) VarValue.AppendAttribute(recordElem, "Order", ssOrder, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "Order");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Is_Active")) VarValue.AppendAttribute(recordElem, "Is_Active", ssIs_Active, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "Is_Active");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
			} else if (head == "label") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
			} else if (head == "order") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
			} else if (head == "is_active") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdLabel)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdOrder)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdIs_Active)) {
				return ChangedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdLabel)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdOrder)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdIs_Active)) {
				return OptimizedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == IdLabel) {
				return ssLabel;
			} else if (key == IdOrder) {
				return ssOrder;
			} else if (key == IdIs_Active) {
				return ssIs_Active;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(4);
			OptimizedAttributes = new BitArray(4);
			if (other == null) return;
			ssid = (int) other.AttributeGet(Idid);
			ChangedAttributes[0] = other.ChangedAttributeGet(Idid);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(Idid);
			ssLabel = (string) other.AttributeGet(IdLabel);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
			ssOrder = (int) other.AttributeGet(IdOrder);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdOrder);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrder);
			ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdIs_Active);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIs_Active);
		}
		public bool IsDefault() {
			ENJobTitleEntityRecord defaultStruct = new ENJobTitleEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssLabel != defaultStruct.ssLabel) return false;
			if (this.ssOrder != defaultStruct.ssOrder) return false;
			if (this.ssIs_Active != defaultStruct.ssIs_Active) return false;
			return true;
		}
	} // ENJobTitleEntityRecord

	public class ENtesteEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "ef158d7b-f666-4ddd-8da2-8958459111da", "12b54621-7b5f-4f3d-95b4-46e36f4b4ea8", "teste", "[Outsystems].[dbo].[teste]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Outsystems].[dbo].[teste]"; 
					}
				} catch {
					return "[Outsystems].[dbo].[teste]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENtesteEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "qaulquer_coisa", "qaulquer_coisa"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENtesteEntityConfiguration.GetPhysicalTableName();
		}
	} // ENtesteEntity

	/// <summary>
	/// Entity <code>ENtesteEntityRecord</code> that represents the Service Studio entity
	///  <code>teste</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("teste", "IUa1El97PU+VtEbjb0tOqA", "e40V72b23U2NoolYRZER2g", 0, "[Outsystems].[dbo].[teste]", null)]
	[Serializable()]
	public partial struct ENtesteEntityRecord: ISerializable, ITypedRecord<ENtesteEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*lOSHVOFy5kO2xE2XvWNJpw");
		internal static readonly GlobalObjectKey Idqaulquer_coisa = GlobalObjectKey.Parse("e40V72b23U2NoolYRZER2g*WW8yLppm_EWOFQb1_R6B+g");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("id", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("id")]
		private int _ssid;
		public int ssid {
			get {
				return _ssid;
			}
			set {
				if ((_ssid!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(2, true);
					_ssid = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("qaulquer_coisa", 50, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("qaulquer_coisa")]
		private string _ssqaulquer_coisa;
		public string ssqaulquer_coisa {
			get {
				return _ssqaulquer_coisa;
			}
			set {
				if ((_ssqaulquer_coisa!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssqaulquer_coisa = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENtesteEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(2, true);
			OptimizedAttributes = new BitArray(2, false);
			_ssid = 0;
			_ssqaulquer_coisa = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssid = r.ReadInteger(index++, "teste.id", 0);
			ssqaulquer_coisa = r.ReadText(index++, "teste.qaulquer_coisa", "");
			ChangedAttributes = new BitArray(2, false);
			OptimizedAttributes = new BitArray(2, false);
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
		public void ReadIM(ENtesteEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENtesteEntityRecord a, ENtesteEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssqaulquer_coisa != b.ssqaulquer_coisa) return false;
			return true;
		}

		public static bool operator != (ENtesteEntityRecord a, ENtesteEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENtesteEntityRecord)) return false;
			return (this == (ENtesteEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssqaulquer_coisa.GetHashCode()
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

		public ENtesteEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(2, true);
			OptimizedAttributes = new BitArray(2, false);
			_ssid = 0;
			_ssqaulquer_coisa = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssqaulquer_coisa", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssqaulquer_coisa' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssqaulquer_coisa = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENtesteEntityRecord Duplicate() {
			ENtesteEntityRecord t;
			t._ssid = this._ssid;
			t._ssqaulquer_coisa = this._ssqaulquer_coisa;
			t.ChangedAttributes = new BitArray(2);
			t.OptimizedAttributes = new BitArray(2);
			for (int i = 0; i < 2; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".id")) VarValue.AppendAttribute(recordElem, "id", ssid, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".qaulquer_coisa")) VarValue.AppendAttribute(recordElem, "qaulquer_coisa", ssqaulquer_coisa, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "qaulquer_coisa");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
			} else if (head == "qaulquer_coisa") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".qaulquer_coisa")) variable.Value = ssqaulquer_coisa; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(Idqaulquer_coisa)) {
				return ChangedAttributes[1];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(Idqaulquer_coisa)) {
				return OptimizedAttributes[1];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == Idqaulquer_coisa) {
				return ssqaulquer_coisa;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(2);
			OptimizedAttributes = new BitArray(2);
			if (other == null) return;
			ssid = (int) other.AttributeGet(Idid);
			ChangedAttributes[0] = other.ChangedAttributeGet(Idid);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(Idid);
			ssqaulquer_coisa = (string) other.AttributeGet(Idqaulquer_coisa);
			ChangedAttributes[1] = other.ChangedAttributeGet(Idqaulquer_coisa);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(Idqaulquer_coisa);
		}
		public bool IsDefault() {
			ENtesteEntityRecord defaultStruct = new ENtesteEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssqaulquer_coisa != defaultStruct.ssqaulquer_coisa) return false;
			return true;
		}
	} // ENtesteEntityRecord

} // OutSystems.NssExtensionAzure
