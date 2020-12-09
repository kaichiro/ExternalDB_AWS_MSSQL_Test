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

	public class ENTypeTableEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "8da730e0-ba37-42d7-b5ba-cdea30c56110", "6afdbbe4-b144-4810-ab97-08c4b13333a6", "TypeTable", "[TestDB].[dbo].[TypeTable]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[TestDB].[dbo].[TypeTable]"; 
					}
				} catch {
					return "[TestDB].[dbo].[TypeTable]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENTypeTableEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENTypeTableEntityConfiguration.GetPhysicalTableName();
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "id", "ID"
				}
				, { "tablename", "TableName"
				}
			};
		}
	} // ENTypeTableEntity

	/// <summary>
	/// Entity <code>ENTypeTableEntityRecord</code> that represents the Service Studio entity
	///  <code>TypeTable</code> <p> Description: Repositório para os nomes das tabelas</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("TypeTable", "5Lv9akSxEEirlwjEsTMzpg", "4DCnjTe610K1us3qMMVhEA", 0, "[TestDB].[dbo].[TypeTable]", null)]
	[Serializable()]
	public partial struct ENTypeTableEntityRecord: ISerializable, ITypedRecord<ENTypeTableEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdID = GlobalObjectKey.Parse("4DCnjTe610K1us3qMMVhEA*S68SbYMzPkq+zqRazOrbNQ");
		internal static readonly GlobalObjectKey IdTableName = GlobalObjectKey.Parse("4DCnjTe610K1us3qMMVhEA*bkmM+zaJH0SjjpElY7bEaw");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ID", 36, false, true, false, true)]
		[System.Xml.Serialization.XmlElement("ID")]
		private string _ssID;
		public string ssID {
			get {
				return _ssID;
			}
			set {
				if ((_ssID!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(2, true);
					_ssID = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("TableName", 128, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("TableName")]
		private string _ssTableName;
		public string ssTableName {
			get {
				return _ssTableName;
			}
			set {
				if ((_ssTableName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssTableName = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENTypeTableEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(2, true);
			OptimizedAttributes = new BitArray(2, false);
			_ssID = "";
			_ssTableName = "";
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
			ssID = r.ReadText(index++, "TypeTable.ID", "");
			ssTableName = r.ReadText(index++, "TypeTable.TableName", "");
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
		public void ReadIM(ENTypeTableEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENTypeTableEntityRecord a, ENTypeTableEntityRecord b) {
			if (a.ssID != b.ssID) return false;
			if (a.ssTableName != b.ssTableName) return false;
			return true;
		}

		public static bool operator != (ENTypeTableEntityRecord a, ENTypeTableEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENTypeTableEntityRecord)) return false;
			return (this == (ENTypeTableEntityRecord) o);
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

		public ENTypeTableEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(2, true);
			OptimizedAttributes = new BitArray(2, false);
			_ssID = "";
			_ssTableName = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssID", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssID' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssID = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssTableName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssTableName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssTableName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENTypeTableEntityRecord Duplicate() {
			ENTypeTableEntityRecord t;
			t._ssID = this._ssID;
			t._ssTableName = this._ssTableName;
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
			if (key.Equals(IdID)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdTableName)) {
				return ChangedAttributes[1];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdID)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdTableName)) {
				return OptimizedAttributes[1];
			} else {
				throw new Exception("Invalid key");
			}
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
			ChangedAttributes = new BitArray(2);
			OptimizedAttributes = new BitArray(2);
			if (other == null) return;
			ssID = (string) other.AttributeGet(IdID);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdID);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdID);
			ssTableName = (string) other.AttributeGet(IdTableName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdTableName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdTableName);
		}
		public bool IsDefault() {
			ENTypeTableEntityRecord defaultStruct = new ENTypeTableEntityRecord(null);
			if (this.ssID != defaultStruct.ssID) return false;
			if (this.ssTableName != defaultStruct.ssTableName) return false;
			return true;
		}
	} // ENTypeTableEntityRecord

} // OutSystems.NssExternalDB_AWS_MSSQL_Test
