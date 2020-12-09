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

namespace OutSystems.NssExternalDB_AWS_MSSQL_Test {

	/// <summary>
	/// RecordList type <code>RLTypeTableRecordList</code> that represents a record list of
	///  <code>TypeTable</code>
	/// </summary>
	[Serializable()]
	public partial class RLTypeTableRecordList: GenericRecordList<RCTypeTableRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTypeTableRecord GetElementDefaultValue() {
			return new RCTypeTableRecord("");
		}

		public T[] ToArray<T>(Func<RCTypeTableRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTypeTableRecordList recordlist, Func<RCTypeTableRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLTypeTableRecordList(RCTypeTableRecord[] array) {
			RLTypeTableRecordList result = new RLTypeTableRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLTypeTableRecordList ToList<T>(T[] array, Func <T, RCTypeTableRecord> converter) {
			RLTypeTableRecordList result = new RLTypeTableRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLTypeTableRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTypeTableRecord> converter) {
			RLTypeTableRecordList result = new RLTypeTableRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLTypeTableRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTypeTableRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTypeTableRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTypeTableRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
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
		protected override OSList<RCTypeTableRecord> NewList() {
			return new RLTypeTableRecordList();
		}


	} // RLTypeTableRecordList

	/// <summary>
	/// RecordList type <code>RLStruct_TypeTableRecordList</code> that represents a record list of
	///  <code>Struct_TypeTable</code>
	/// </summary>
	[Serializable()]
	public partial class RLStruct_TypeTableRecordList: GenericRecordList<RCStruct_TypeTableRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCStruct_TypeTableRecord GetElementDefaultValue() {
			return new RCStruct_TypeTableRecord("");
		}

		public T[] ToArray<T>(Func<RCStruct_TypeTableRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLStruct_TypeTableRecordList recordlist, Func<RCStruct_TypeTableRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLStruct_TypeTableRecordList(RCStruct_TypeTableRecord[] array) {
			RLStruct_TypeTableRecordList result = new RLStruct_TypeTableRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLStruct_TypeTableRecordList ToList<T>(T[] array, Func <T, RCStruct_TypeTableRecord> converter) {
			RLStruct_TypeTableRecordList result = new RLStruct_TypeTableRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLStruct_TypeTableRecordList FromRestList<T>(RestList<T> restList, Func <T, RCStruct_TypeTableRecord> converter) {
			RLStruct_TypeTableRecordList result = new RLStruct_TypeTableRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLStruct_TypeTableRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLStruct_TypeTableRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLStruct_TypeTableRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLStruct_TypeTableRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCStruct_TypeTableRecord> NewList() {
			return new RLStruct_TypeTableRecordList();
		}


	} // RLStruct_TypeTableRecordList
}
