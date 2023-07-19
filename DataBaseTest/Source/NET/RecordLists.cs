using System;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.NewRuntime;

namespace OutSystems.NssDataBaseTest {

	/// <summary>
	/// RecordList type <code>RLNewTableRecordList</code> that represents a record list of
	///  <code>NewTable</code>
	/// </summary>
	[Serializable()]
	public partial class RLNewTableRecordList: GenericRecordList<RCNewTableRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCNewTableRecord GetElementDefaultValue() {
			return new RCNewTableRecord("");
		}

		public T[] ToArray<T>(Func<RCNewTableRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLNewTableRecordList recordlist, Func<RCNewTableRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLNewTableRecordList(RCNewTableRecord[] array) {
			RLNewTableRecordList result = new RLNewTableRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLNewTableRecordList ToList<T>(T[] array, Func <T, RCNewTableRecord> converter) {
			RLNewTableRecordList result = new RLNewTableRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLNewTableRecordList FromRestList<T>(RestList<T> restList, Func <T, RCNewTableRecord> converter) {
			RLNewTableRecordList result = new RLNewTableRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLNewTableRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLNewTableRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLNewTableRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLNewTableRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(2, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCNewTableRecord> NewList() {
			return new RLNewTableRecordList();
		}


	} // RLNewTableRecordList
}
