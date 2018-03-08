using System;

namespace test
{
    public class SmokeTest : IntegrationTestBase
    {
//        [Fact] //(Skip = "Native dependencies missing in CI. See https://github.com/dotnet/corefx/issues/15776.")]
        public void DraftTest()
        {
            command.CommandText =
                @"CREATE TABLE SomeTable (
                    SomeByte TINYINT,
                    SomeBoolean BIT,
                    SomeDate DATE,
                    SomeDateTime DATETIME,
                    SomeDecimal DECIMAL(10,5),
                    SomeDouble FLOAT,
                    SomeFloat REAL,
                    SomeGuid UNIQUEIDENTIFIER,
                    SomeInt32 INT,
                    SomeInt64 BIGINT,
                    SomeString NVARCHAR(100))";
            command.ExecuteNonQuery();

            using (var reader = command.ExecuteReader())
            {
                reader.Read();
 //               Assert.Equal((byte)7, reader.GetByte(0));
   //             Assert.Equal(true, reader.GetBoolean(1));
     //           Assert.Equal(new DateTime(2010, 12, 13), reader.GetDate(2));
       //         Assert.Equal(new DateTime(2016, 2, 29, 22, 33, 44), reader.GetDateTime(3));
         //       Assert.Equal(12345.12002m, reader.GetDecimal(4));
         //       Assert.Equal(1.00000001d, reader.GetDouble(5));
          //      Assert.Equal(1f, reader.GetFloat(6));
          //      // SQLite Driver does not support this parameter
                //Assert.Equal(new Guid("9b7c0b33-d38b-4d89-a3b2-0202c55ce6e5"), reader.GetGuid(7));
          //      Assert.Equal(32767532, reader.GetInt32(8));
            //    Assert.Equal(21474836479999, reader.GetInt64(9));
              //  Assert.Equal("SomeString", reader.GetString(10));
            }
        }
    }
}
