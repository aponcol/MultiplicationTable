using NUnit.Framework;
using System;
using MultiplicationTable.Models;
using static MultiplicationTable.Models.TableGenerator;

namespace MultiplicationTable.Tests.Models
{
    [TestFixture()]
    public class TableGeneratorTest
    {
        const int defaultMatrixSize = 10;

        [Test()]
        public void WhenNoMatrixSizeIsGivenReturns10x10Table()
        {
            int[,] table = GetDefaultTable();
            Assert.AreEqual(defaultMatrixSize, table.GetLength(0));
            Assert.AreEqual(defaultMatrixSize, table.GetLength(1));
        }

        [Test()]
		public void WhenNoMatrixSizeIsGivenFirstRowAscendsFrom1To10()
		{
            int[,] table = GetDefaultTable();
            for (int i = 0; i < defaultMatrixSize; i++) {
                Assert.AreEqual(i+1, table[i, 0]);
            }
		}

		[Test()]
		public void WhenNoMatrixSizeIsGivenFirstColumnAscendsFrom1To10()
		{
			int[,] table = GetDefaultTable();
			for (int i = 0; i < defaultMatrixSize; i++)
			{
				Assert.AreEqual(i + 1, table[0, i]);
			}
		}

        [Test()]
        public void WhenNoMatrixSizeIsGivenTheMainDiagonalIsPowerOf2OfIndex()
		{
			int[,] table = GetDefaultTable();
			for (int i = 0; i < defaultMatrixSize; i++) {
                Assert.AreEqual((int)Math.Pow(i + 1, 2), table[i, i]);
			}
		}

        protected int[,] GetDefaultTable()
        {
			TableGenerator tableGenerator = new TableGenerator();
			return tableGenerator.GetTable();
        }

        [Test()]
        [ExpectedException(typeof(ArgumentException))]
        public void WhenMatrixSizeGivenIsLessThan3MatrixTooSmallExceptionIsThrown()
        {
            TableGenerator tableGenerator = new TableGenerator();
            tableGenerator.GetTable(2);
        }

		[Test()]
		[ExpectedException(typeof(ArgumentException))]
		public void WhenMatrixSizeGivenIsMoreThan15MatrixTooBigExceptionIsThrown()
		{
			TableGenerator tableGenerator = new TableGenerator();
			tableGenerator.GetTable(16);
		}

		[Test()]
		public void WhenMatrixSizeIsGivenTheSizeOfTableReturnedIsTheMatrixSize()
		{
			TableGenerator tableGenerator = new TableGenerator();
			int[,] table = tableGenerator.GetTable(8);
            Assert.AreEqual(8, table.GetLength(0));
            Assert.AreEqual(8, table.GetLength(1));
		}
    }
}
