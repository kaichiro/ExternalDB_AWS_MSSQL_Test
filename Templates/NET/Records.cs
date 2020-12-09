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

namespace OutSystems.NssExternalDB_AWS_MSSQL_Test {

	/// <summary>
	/// Structure <code>RCTypeTableRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTypeTableRecord: ISerializable, ITypedRecord<RCTypeTableRecord> {
		internal static readonly GlobalObjectKey IdTypeTable = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*h06XATkx_jLtbhy+npX3kQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("TypeTable")]
		public ENTypeTableEntityRecord ssENTypeTable;


		public static implicit operator ENTypeTableEntityRecord(RCTypeTableRecord r) {
			return r.ssENTypeTable;
		}

		public static implicit operator RCTypeTableRecord(ENTypeTableEntityRecord r) {
			RCTypeTableRecord res = new RCTypeTableRecord(null);
			res.ssENTypeTable = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENTypeTable.ChangedAttributes = value;
			}
			get {
				return ssENTypeTable.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCTypeTableRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENTypeTable = new ENTypeTableEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(2, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENTypeTable.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENTypeTable.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENTypeTable.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENTypeTable.Read(r, ref index);
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
		public void ReadIM(RCTypeTableRecord r) {
			this = r;
		}


		public static bool operator == (RCTypeTableRecord a, RCTypeTableRecord b) {
			if (a.ssENTypeTable != b.ssENTypeTable) return false;
			return true;
		}

		public static bool operator != (RCTypeTableRecord a, RCTypeTableRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTypeTableRecord)) return false;
			return (this == (RCTypeTableRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENTypeTable.GetHashCode()
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

		public RCTypeTableRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENTypeTable = new ENTypeTableEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENTypeTable", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENTypeTable' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENTypeTable = (ENTypeTableEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENTypeTable.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENTypeTable.InternalRecursiveSave();
		}


		public RCTypeTableRecord Duplicate() {
			RCTypeTableRecord t;
			t.ssENTypeTable = (ENTypeTableEntityRecord) this.ssENTypeTable.Duplicate();
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
				ssENTypeTable.ToXml(this, recordElem, "TypeTable", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "typetable") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TypeTable")) variable.Value = ssENTypeTable; else variable.Optimized = true;
				variable.SetFieldName("typetable");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENTypeTable.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENTypeTable.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdTypeTable) {
				return ssENTypeTable;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENTypeTable.FillFromOther((IRecord) other.AttributeGet(IdTypeTable));
		}
		public bool IsDefault() {
			RCTypeTableRecord defaultStruct = new RCTypeTableRecord(null);
			if (this.ssENTypeTable != defaultStruct.ssENTypeTable) return false;
			return true;
		}
	} // RCTypeTableRecord

	/// <summary>
	/// Structure <code>RCStruct_TypeTableRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCStruct_TypeTableRecord: ISerializable, ITypedRecord<RCStruct_TypeTableRecord> {
		internal static readonly GlobalObjectKey IdStruct_TypeTable = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*p1UqvGaJA2_rWvQaPLJL_A");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Struct_TypeTable")]
		public STStruct_TypeTableStructure ssSTStruct_TypeTable;


		public static implicit operator STStruct_TypeTableStructure(RCStruct_TypeTableRecord r) {
			return r.ssSTStruct_TypeTable;
		}

		public static implicit operator RCStruct_TypeTableRecord(STStruct_TypeTableStructure r) {
			RCStruct_TypeTableRecord res = new RCStruct_TypeTableRecord(null);
			res.ssSTStruct_TypeTable = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCStruct_TypeTableRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTStruct_TypeTable = new STStruct_TypeTableStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTStruct_TypeTable.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTStruct_TypeTable.Read(r, ref index);
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
		public void ReadIM(RCStruct_TypeTableRecord r) {
			this = r;
		}


		public static bool operator == (RCStruct_TypeTableRecord a, RCStruct_TypeTableRecord b) {
			if (a.ssSTStruct_TypeTable != b.ssSTStruct_TypeTable) return false;
			return true;
		}

		public static bool operator != (RCStruct_TypeTableRecord a, RCStruct_TypeTableRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCStruct_TypeTableRecord)) return false;
			return (this == (RCStruct_TypeTableRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTStruct_TypeTable.GetHashCode()
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

		public RCStruct_TypeTableRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTStruct_TypeTable = new STStruct_TypeTableStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTStruct_TypeTable", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTStruct_TypeTable' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTStruct_TypeTable = (STStruct_TypeTableStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTStruct_TypeTable.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTStruct_TypeTable.InternalRecursiveSave();
		}


		public RCStruct_TypeTableRecord Duplicate() {
			RCStruct_TypeTableRecord t;
			t.ssSTStruct_TypeTable = (STStruct_TypeTableStructure) this.ssSTStruct_TypeTable.Duplicate();
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
				ssSTStruct_TypeTable.ToXml(this, recordElem, "Struct_TypeTable", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "struct_typetable") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Struct_TypeTable")) variable.Value = ssSTStruct_TypeTable; else variable.Optimized = true;
				variable.SetFieldName("struct_typetable");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdStruct_TypeTable) {
				return ssSTStruct_TypeTable;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTStruct_TypeTable.FillFromOther((IRecord) other.AttributeGet(IdStruct_TypeTable));
		}
		public bool IsDefault() {
			RCStruct_TypeTableRecord defaultStruct = new RCStruct_TypeTableRecord(null);
			if (this.ssSTStruct_TypeTable != defaultStruct.ssSTStruct_TypeTable) return false;
			return true;
		}
	} // RCStruct_TypeTableRecord
}
