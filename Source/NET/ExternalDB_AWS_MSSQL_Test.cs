using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;

namespace OutSystems.NssExternalDB_AWS_MSSQL_Test {

	public class CssExternalDB_AWS_MSSQL_Test: IssExternalDB_AWS_MSSQL_Test {

		/// <summary>
		/// Retorna a quantidade máxima de registros para um Aggregate ou SQL Advanced
		/// </summary>
		/// <param name="ssCount">Retorna um inteiro cujo valor é 99.999</param>
		public void MssMaxRecords(out int ssCount) {
			ssCount = 99999;
			// TODO: Write implementation for action
		} // MssMaxRecords

	} // CssExternalDB_AWS_MSSQL_Test

} // OutSystems.NssExternalDB_AWS_MSSQL_Test

