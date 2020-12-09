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

namespace OutSystems.NssExternalDB_AWS_MSSQL_Test {

	/// <summary>
	/// Structure <code>STStruct_TypeTableStructure</code> that represents the Service Studio structure
	///  <code>Struct_TypeTable</code> <p> Description: Estrutura para a tabela de tipos de tabela</p>
	/// </summary>
	[Serializable()]
	public partial struct STStruct_TypeTableStructure: ISerializable, ITypedRecord<STStruct_TypeTableStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdID = GlobalObjectKey.Parse("4DCnjTe610K1us3qMMVhEA*KWxk7igytUicUnXPVt4Nqw");
		internal static readonly GlobalObjectKey IdTableName = GlobalObjectKey.Parse("4DCnjTe610K1us3qMMVhEA*OXHcLs0tc0+StSbIyWTS7A");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ID")]
		public string ssID;

		[System.Xml.Serialization.XmlElement("TableName")]
		public string ssTableName;


		public BitArray OptimizedAttributes;

		public STStruct_TypeTableStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssID = "";
			ssTableName = "";
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
			ssID = r.ReadText(index++, "Struct_TypeTable.ID", "");
			ssTableName = r.ReadText(index++, "Struct_TypeTable.TableName", "");
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
		public void ReadIM(STStruct_TypeTableStructure r) {
			this = r;
		}


		public static bool operator == (STStruct_TypeTableStructure a, STStruct_TypeTableStructure b) {
			if (a.ssID != b.ssID) return false;
			if (a.ssTableName != b.ssTableName) return false;
			return true;
		}

		public static bool operator != (STStruct_TypeTableStructure a, STStruct_TypeTableStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STStruct_TypeTableStructure)) return false;
			return (this == (STStruct_TypeTableStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssID.GetHashCode()
				^ ssTableName.GetHashCode()
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

		public STStruct_TypeTableStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssID = "";
			ssTableName = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssID", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssID' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssID = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssTableName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssTableName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssTableName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STStruct_TypeTableStructure Duplicate() {
			STStruct_TypeTableStructure t;
			t.ssID = this.ssID;
			t.ssTableName = this.ssTableName;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ID")) VarValue.AppendAttribute(recordElem, "ID", ssID, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "ID");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".TableName")) VarValue.AppendAttribute(recordElem, "TableName", ssTableName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "TableName");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ID")) variable.Value = ssID; else variable.Optimized = true;
			} else if (head == "tablename") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TableName")) variable.Value = ssTableName; else variable.Optimized = true;
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
			if (key == IdID) {
				return ssID;
			} else if (key == IdTableName) {
				return ssTableName;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssID = (string) other.AttributeGet(IdID);
			ssTableName = (string) other.AttributeGet(IdTableName);
		}
		public bool IsDefault() {
			STStruct_TypeTableStructure defaultStruct = new STStruct_TypeTableStructure(null);
			if (this.ssID != defaultStruct.ssID) return false;
			if (this.ssTableName != defaultStruct.ssTableName) return false;
			return true;
		}
	} // STStruct_TypeTableStructure

} // OutSystems.NssExternalDB_AWS_MSSQL_Test
