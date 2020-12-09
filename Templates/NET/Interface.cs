using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssExternalDB_AWS_MSSQL_Test {

	public interface IssExternalDB_AWS_MSSQL_Test {

		/// <summary>
		/// Retorna a quantidade máxima de registros para um Aggregate ou SQL Advanced
		/// </summary>
		/// <param name="ssCount">Retorna um inteiro cujo valor é 99.999</param>
		void MssMaxRecords(out int ssCount);

	} // IssExternalDB_AWS_MSSQL_Test

} // OutSystems.NssExternalDB_AWS_MSSQL_Test
