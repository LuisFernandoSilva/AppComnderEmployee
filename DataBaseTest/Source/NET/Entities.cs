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

namespace OutSystems.NssDataBaseTest {

	public class ENNewTableEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "a2255a45-dc68-4615-a26d-f5f3bed7b7c2", "5d27e21a-f784-43bd-9cd6-8481fb33d49e", "NewTable", "[Data_Base_Test].[dbo].[NewTable]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Data_Base_Test].[dbo].[NewTable]"; 
					}
				} catch {
					return "[Data_Base_Test].[dbo].[NewTable]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENNewTableEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "id"
			}
			, { "text", "Text"
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
			return ENNewTableEntityConfiguration.GetPhysicalTableName();
		}
	} // ENNewTableEntity

	/// <summary>
	/// Entity <code>ENNewTableEntityRecord</code> that represents the Service Studio entity
	///  <code>NewTable</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("NewTable", "GuInXYT3vUOc1oSB+zPUng", "RVolomjcFUaibfXzvte3wg", 0, "[Data_Base_Test].[dbo].[NewTable]", null)]
	[Serializable()]
	public partial struct ENNewTableEntityRecord: ISerializable, ITypedRecord<ENNewTableEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("RVolomjcFUaibfXzvte3wg*VpSS+qFplkaGcteMvsKs7w");
		internal static readonly GlobalObjectKey IdText = GlobalObjectKey.Parse("RVolomjcFUaibfXzvte3wg*DUrlYSVffUaI1sV9EPysMA");

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

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Text", 50, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Text")]
		private string _ssText;
		public string ssText {
			get {
				return _ssText;
			}
			set {
				if ((_ssText!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssText = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENNewTableEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(2, true);
			OptimizedAttributes = new BitArray(2, false);
			_ssid = 0;
			_ssText = "";
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
			ssid = r.ReadInteger(index++, "NewTable.id", 0);
			ssText = r.ReadText(index++, "NewTable.Text", "");
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
		public void ReadIM(ENNewTableEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENNewTableEntityRecord a, ENNewTableEntityRecord b) {
			if (a.ssid != b.ssid) return false;
			if (a.ssText != b.ssText) return false;
			return true;
		}

		public static bool operator != (ENNewTableEntityRecord a, ENNewTableEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENNewTableEntityRecord)) return false;
			return (this == (ENNewTableEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssid.GetHashCode()
				^ ssText.GetHashCode()
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

		public ENNewTableEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(2, true);
			OptimizedAttributes = new BitArray(2, false);
			_ssid = 0;
			_ssText = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssid", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssid' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssid = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssText", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssText' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssText = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENNewTableEntityRecord Duplicate() {
			ENNewTableEntityRecord t;
			t._ssid = this._ssid;
			t._ssText = this._ssText;
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
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Text")) VarValue.AppendAttribute(recordElem, "Text", ssText, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Text");
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
			} else if (head == "text") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Text")) variable.Value = ssText; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdText)) {
				return ChangedAttributes[1];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(Idid)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdText)) {
				return OptimizedAttributes[1];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idid) {
				return ssid;
			} else if (key == IdText) {
				return ssText;
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
			ssText = (string) other.AttributeGet(IdText);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdText);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdText);
		}
		public bool IsDefault() {
			ENNewTableEntityRecord defaultStruct = new ENNewTableEntityRecord(null);
			if (this.ssid != defaultStruct.ssid) return false;
			if (this.ssText != defaultStruct.ssText) return false;
			return true;
		}
	} // ENNewTableEntityRecord

} // OutSystems.NssDataBaseTest
