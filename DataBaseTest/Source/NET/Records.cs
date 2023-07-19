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

namespace OutSystems.NssDataBaseTest {

	/// <summary>
	/// Structure <code>RCNewTableRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCNewTableRecord: ISerializable, ITypedRecord<RCNewTableRecord> {
		internal static readonly GlobalObjectKey IdNewTable = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PAeDHBfWZz0ffouGw6DXGQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("NewTable")]
		public ENNewTableEntityRecord ssENNewTable;


		public static implicit operator ENNewTableEntityRecord(RCNewTableRecord r) {
			return r.ssENNewTable;
		}

		public static implicit operator RCNewTableRecord(ENNewTableEntityRecord r) {
			RCNewTableRecord res = new RCNewTableRecord(null);
			res.ssENNewTable = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENNewTable.ChangedAttributes = value;
			}
			get {
				return ssENNewTable.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCNewTableRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENNewTable = new ENNewTableEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(2, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENNewTable.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENNewTable.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENNewTable.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENNewTable.Read(r, ref index);
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
		public void ReadIM(RCNewTableRecord r) {
			this = r;
		}


		public static bool operator == (RCNewTableRecord a, RCNewTableRecord b) {
			if (a.ssENNewTable != b.ssENNewTable) return false;
			return true;
		}

		public static bool operator != (RCNewTableRecord a, RCNewTableRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCNewTableRecord)) return false;
			return (this == (RCNewTableRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENNewTable.GetHashCode()
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

		public RCNewTableRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENNewTable = new ENNewTableEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENNewTable", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENNewTable' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENNewTable = (ENNewTableEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENNewTable.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENNewTable.InternalRecursiveSave();
		}


		public RCNewTableRecord Duplicate() {
			RCNewTableRecord t;
			t.ssENNewTable = (ENNewTableEntityRecord) this.ssENNewTable.Duplicate();
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
				ssENNewTable.ToXml(this, recordElem, "NewTable", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "newtable") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".NewTable")) variable.Value = ssENNewTable; else variable.Optimized = true;
				variable.SetFieldName("newtable");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENNewTable.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENNewTable.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdNewTable) {
				return ssENNewTable;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENNewTable.FillFromOther((IRecord) other.AttributeGet(IdNewTable));
		}
		public bool IsDefault() {
			RCNewTableRecord defaultStruct = new RCNewTableRecord(null);
			if (this.ssENNewTable != defaultStruct.ssENNewTable) return false;
			return true;
		}
	} // RCNewTableRecord
}
