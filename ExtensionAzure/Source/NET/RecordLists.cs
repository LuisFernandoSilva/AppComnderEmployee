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

namespace OutSystems.NssExtensionAzure {

	/// <summary>
	/// RecordList type <code>RLEmployeePhotoRecordList</code> that represents a record list of
	///  <code>EmployeePhoto</code>
	/// </summary>
	[Serializable()]
	public partial class RLEmployeePhotoRecordList: GenericRecordList<RCEmployeePhotoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEmployeePhotoRecord GetElementDefaultValue() {
			return new RCEmployeePhotoRecord("");
		}

		public T[] ToArray<T>(Func<RCEmployeePhotoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEmployeePhotoRecordList recordlist, Func<RCEmployeePhotoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEmployeePhotoRecordList(RCEmployeePhotoRecord[] array) {
			RLEmployeePhotoRecordList result = new RLEmployeePhotoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEmployeePhotoRecordList ToList<T>(T[] array, Func <T, RCEmployeePhotoRecord> converter) {
			RLEmployeePhotoRecordList result = new RLEmployeePhotoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEmployeePhotoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEmployeePhotoRecord> converter) {
			RLEmployeePhotoRecordList result = new RLEmployeePhotoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEmployeePhotoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEmployeePhotoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEmployeePhotoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEmployeePhotoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(8, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEmployeePhotoRecord> NewList() {
			return new RLEmployeePhotoRecordList();
		}


	} // RLEmployeePhotoRecordList

	/// <summary>
	/// RecordList type <code>RLDepartmentRecordList</code> that represents a record list of
	///  <code>Department</code>
	/// </summary>
	[Serializable()]
	public partial class RLDepartmentRecordList: GenericRecordList<RCDepartmentRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDepartmentRecord GetElementDefaultValue() {
			return new RCDepartmentRecord("");
		}

		public T[] ToArray<T>(Func<RCDepartmentRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDepartmentRecordList recordlist, Func<RCDepartmentRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDepartmentRecordList(RCDepartmentRecord[] array) {
			RLDepartmentRecordList result = new RLDepartmentRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDepartmentRecordList ToList<T>(T[] array, Func <T, RCDepartmentRecord> converter) {
			RLDepartmentRecordList result = new RLDepartmentRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDepartmentRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDepartmentRecord> converter) {
			RLDepartmentRecordList result = new RLDepartmentRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDepartmentRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDepartmentRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDepartmentRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDepartmentRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(3, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDepartmentRecord> NewList() {
			return new RLDepartmentRecordList();
		}


	} // RLDepartmentRecordList

	/// <summary>
	/// RecordList type <code>RLBranchRecordList</code> that represents a record list of
	///  <code>Branch</code>
	/// </summary>
	[Serializable()]
	public partial class RLBranchRecordList: GenericRecordList<RCBranchRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCBranchRecord GetElementDefaultValue() {
			return new RCBranchRecord("");
		}

		public T[] ToArray<T>(Func<RCBranchRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLBranchRecordList recordlist, Func<RCBranchRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLBranchRecordList(RCBranchRecord[] array) {
			RLBranchRecordList result = new RLBranchRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLBranchRecordList ToList<T>(T[] array, Func <T, RCBranchRecord> converter) {
			RLBranchRecordList result = new RLBranchRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLBranchRecordList FromRestList<T>(RestList<T> restList, Func <T, RCBranchRecord> converter) {
			RLBranchRecordList result = new RLBranchRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLBranchRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLBranchRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLBranchRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLBranchRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(3, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCBranchRecord> NewList() {
			return new RLBranchRecordList();
		}


	} // RLBranchRecordList

	/// <summary>
	/// RecordList type <code>RLPayrollRecordList</code> that represents a record list of
	///  <code>Payroll</code>
	/// </summary>
	[Serializable()]
	public partial class RLPayrollRecordList: GenericRecordList<RCPayrollRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCPayrollRecord GetElementDefaultValue() {
			return new RCPayrollRecord("");
		}

		public T[] ToArray<T>(Func<RCPayrollRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLPayrollRecordList recordlist, Func<RCPayrollRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLPayrollRecordList(RCPayrollRecord[] array) {
			RLPayrollRecordList result = new RLPayrollRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLPayrollRecordList ToList<T>(T[] array, Func <T, RCPayrollRecord> converter) {
			RLPayrollRecordList result = new RLPayrollRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLPayrollRecordList FromRestList<T>(RestList<T> restList, Func <T, RCPayrollRecord> converter) {
			RLPayrollRecordList result = new RLPayrollRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLPayrollRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLPayrollRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLPayrollRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLPayrollRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(8, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCPayrollRecord> NewList() {
			return new RLPayrollRecordList();
		}


	} // RLPayrollRecordList

	/// <summary>
	/// RecordList type <code>RLNewsRecordList</code> that represents a record list of <code>News</code>
	/// </summary>
	[Serializable()]
	public partial class RLNewsRecordList: GenericRecordList<RCNewsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCNewsRecord GetElementDefaultValue() {
			return new RCNewsRecord("");
		}

		public T[] ToArray<T>(Func<RCNewsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLNewsRecordList recordlist, Func<RCNewsRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLNewsRecordList(RCNewsRecord[] array) {
			RLNewsRecordList result = new RLNewsRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLNewsRecordList ToList<T>(T[] array, Func <T, RCNewsRecord> converter) {
			RLNewsRecordList result = new RLNewsRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLNewsRecordList FromRestList<T>(RestList<T> restList, Func <T, RCNewsRecord> converter) {
			RLNewsRecordList result = new RLNewsRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLNewsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLNewsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLNewsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLNewsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(10, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCNewsRecord> NewList() {
			return new RLNewsRecordList();
		}


	} // RLNewsRecordList

	/// <summary>
	/// RecordList type <code>RLTimeSheetPDFRecordList</code> that represents a record list of
	///  <code>TimeSheetPDF</code>
	/// </summary>
	[Serializable()]
	public partial class RLTimeSheetPDFRecordList: GenericRecordList<RCTimeSheetPDFRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTimeSheetPDFRecord GetElementDefaultValue() {
			return new RCTimeSheetPDFRecord("");
		}

		public T[] ToArray<T>(Func<RCTimeSheetPDFRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTimeSheetPDFRecordList recordlist, Func<RCTimeSheetPDFRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLTimeSheetPDFRecordList(RCTimeSheetPDFRecord[] array) {
			RLTimeSheetPDFRecordList result = new RLTimeSheetPDFRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLTimeSheetPDFRecordList ToList<T>(T[] array, Func <T, RCTimeSheetPDFRecord> converter) {
			RLTimeSheetPDFRecordList result = new RLTimeSheetPDFRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLTimeSheetPDFRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTimeSheetPDFRecord> converter) {
			RLTimeSheetPDFRecordList result = new RLTimeSheetPDFRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLTimeSheetPDFRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTimeSheetPDFRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTimeSheetPDFRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTimeSheetPDFRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(8, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCTimeSheetPDFRecord> NewList() {
			return new RLTimeSheetPDFRecordList();
		}


	} // RLTimeSheetPDFRecordList

	/// <summary>
	/// RecordList type <code>RLPayrollPDFRecordList</code> that represents a record list of
	///  <code>PayrollPDF</code>
	/// </summary>
	[Serializable()]
	public partial class RLPayrollPDFRecordList: GenericRecordList<RCPayrollPDFRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCPayrollPDFRecord GetElementDefaultValue() {
			return new RCPayrollPDFRecord("");
		}

		public T[] ToArray<T>(Func<RCPayrollPDFRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLPayrollPDFRecordList recordlist, Func<RCPayrollPDFRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLPayrollPDFRecordList(RCPayrollPDFRecord[] array) {
			RLPayrollPDFRecordList result = new RLPayrollPDFRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLPayrollPDFRecordList ToList<T>(T[] array, Func <T, RCPayrollPDFRecord> converter) {
			RLPayrollPDFRecordList result = new RLPayrollPDFRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLPayrollPDFRecordList FromRestList<T>(RestList<T> restList, Func <T, RCPayrollPDFRecord> converter) {
			RLPayrollPDFRecordList result = new RLPayrollPDFRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLPayrollPDFRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLPayrollPDFRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLPayrollPDFRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLPayrollPDFRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(8, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCPayrollPDFRecord> NewList() {
			return new RLPayrollPDFRecordList();
		}


	} // RLPayrollPDFRecordList

	/// <summary>
	/// RecordList type <code>RLTimeSheetRecordList</code> that represents a record list of
	///  <code>TimeSheet</code>
	/// </summary>
	[Serializable()]
	public partial class RLTimeSheetRecordList: GenericRecordList<RCTimeSheetRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTimeSheetRecord GetElementDefaultValue() {
			return new RCTimeSheetRecord("");
		}

		public T[] ToArray<T>(Func<RCTimeSheetRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTimeSheetRecordList recordlist, Func<RCTimeSheetRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLTimeSheetRecordList(RCTimeSheetRecord[] array) {
			RLTimeSheetRecordList result = new RLTimeSheetRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLTimeSheetRecordList ToList<T>(T[] array, Func <T, RCTimeSheetRecord> converter) {
			RLTimeSheetRecordList result = new RLTimeSheetRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLTimeSheetRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTimeSheetRecord> converter) {
			RLTimeSheetRecordList result = new RLTimeSheetRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLTimeSheetRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTimeSheetRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTimeSheetRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTimeSheetRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(8, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCTimeSheetRecord> NewList() {
			return new RLTimeSheetRecordList();
		}


	} // RLTimeSheetRecordList

	/// <summary>
	/// RecordList type <code>RLJobTitleRecordList</code> that represents a record list of
	///  <code>JobTitle</code>
	/// </summary>
	[Serializable()]
	public partial class RLJobTitleRecordList: GenericRecordList<RCJobTitleRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCJobTitleRecord GetElementDefaultValue() {
			return new RCJobTitleRecord("");
		}

		public T[] ToArray<T>(Func<RCJobTitleRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLJobTitleRecordList recordlist, Func<RCJobTitleRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLJobTitleRecordList(RCJobTitleRecord[] array) {
			RLJobTitleRecordList result = new RLJobTitleRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLJobTitleRecordList ToList<T>(T[] array, Func <T, RCJobTitleRecord> converter) {
			RLJobTitleRecordList result = new RLJobTitleRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLJobTitleRecordList FromRestList<T>(RestList<T> restList, Func <T, RCJobTitleRecord> converter) {
			RLJobTitleRecordList result = new RLJobTitleRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLJobTitleRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLJobTitleRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLJobTitleRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLJobTitleRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(3, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCJobTitleRecord> NewList() {
			return new RLJobTitleRecordList();
		}


	} // RLJobTitleRecordList

	/// <summary>
	/// RecordList type <code>RLFaQRecordList</code> that represents a record list of <code>FaQ</code>
	/// </summary>
	[Serializable()]
	public partial class RLFaQRecordList: GenericRecordList<RCFaQRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCFaQRecord GetElementDefaultValue() {
			return new RCFaQRecord("");
		}

		public T[] ToArray<T>(Func<RCFaQRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLFaQRecordList recordlist, Func<RCFaQRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLFaQRecordList(RCFaQRecord[] array) {
			RLFaQRecordList result = new RLFaQRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLFaQRecordList ToList<T>(T[] array, Func <T, RCFaQRecord> converter) {
			RLFaQRecordList result = new RLFaQRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLFaQRecordList FromRestList<T>(RestList<T> restList, Func <T, RCFaQRecord> converter) {
			RLFaQRecordList result = new RLFaQRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLFaQRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLFaQRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLFaQRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLFaQRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(8, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCFaQRecord> NewList() {
			return new RLFaQRecordList();
		}


	} // RLFaQRecordList

	/// <summary>
	/// RecordList type <code>RLEmployeeRecordList</code> that represents a record list of
	///  <code>Employee</code>
	/// </summary>
	[Serializable()]
	public partial class RLEmployeeRecordList: GenericRecordList<RCEmployeeRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEmployeeRecord GetElementDefaultValue() {
			return new RCEmployeeRecord("");
		}

		public T[] ToArray<T>(Func<RCEmployeeRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEmployeeRecordList recordlist, Func<RCEmployeeRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEmployeeRecordList(RCEmployeeRecord[] array) {
			RLEmployeeRecordList result = new RLEmployeeRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEmployeeRecordList ToList<T>(T[] array, Func <T, RCEmployeeRecord> converter) {
			RLEmployeeRecordList result = new RLEmployeeRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEmployeeRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEmployeeRecord> converter) {
			RLEmployeeRecordList result = new RLEmployeeRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEmployeeRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEmployeeRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEmployeeRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEmployeeRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(18, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEmployeeRecord> NewList() {
			return new RLEmployeeRecordList();
		}


	} // RLEmployeeRecordList
}
