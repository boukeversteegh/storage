﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Net
{
   /// <summary>
   /// Known storage account prefixes
   /// </summary>
   public static class KnownPrefix
   {
      /// <summary>
      /// Amazon S3
      /// </summary>
      public static string AwsS3 = "aws.s3";

      /// <summary>
      /// Azure Databricks DBFS
      /// </summary>
      public static string DatabricksDbfs = "azure.databricks.dbfs";

      /// <summary>
      /// Azure Data Lake Gen 1
      /// </summary>
      public static string AzureDataLakeGen1 = "azure.datalake.gen1";

      /// <summary>
      /// Azure Data Lake Gen 2
      /// </summary>
      public static string AzureDataLakeGen2 = "azure.datalake.gen2";

      /// <summary>
      /// Azure Key Vault
      /// </summary>
      public static string AzureKeyVault = "azure.keyvault";
   }
}