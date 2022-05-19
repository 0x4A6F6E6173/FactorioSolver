using NUnit.Framework;
using SearchTool;
using System.Collections.Generic; // Needed to avoid name collision between NUnit List and Generic List<>

namespace FactorioTest
{
    /*
        [Test, Order()]
        public void _() 
        {

        }
    */

    [TestFixture]
    public class Search_TestContainsString
    {
        [Test, Order(1)]
        public void ContainsString_QueryNotContainedInSearchSpace()
        {
            var randomSearchSpace = "1idoieogi42hfwq9023u48t02843";
            var queryNotContainedInSearchSpace = " ";
            var query = new SearchQuery(randomSearchSpace, queryNotContainedInSearchSpace);

            bool result = Search.ContainsString(query);

            Assert.IsFalse(result);
        }

        [Test, Order(2)]
        public void ContainsString_String_QueryContainedInSearchSpace()
        {
            var randomSearchSpace = "1idoieogi42hfwq9023u48t02843";
            var queryContainedInSearchSpace = "1i";
            var query = new SearchQuery(randomSearchSpace, queryContainedInSearchSpace);

            bool result = Search.ContainsString(query);

            Assert.IsTrue(result);
        }

        [Test, Order(3)]
        public void ContainsString_SingleCharacter_QueryContainedInSearchSpace()
        {
            var randomSearchSpace = "1idoieogi42hfwq9023u48t02843";
            var queryContainedInSearchSpace = "1";
            var query = new SearchQuery(randomSearchSpace, queryContainedInSearchSpace);

            bool result = Search.ContainsString(query);

            Assert.IsTrue(result);
        }

        [Test, Order(4)]
        public void ContainsString_String_QueryContainedInTheSearchSpace_PlacedAtTheEnd()
        {
            var randomSearchSpace = "1idoieogi42hfwq9023u48t02843";
            var queryContainedInSearchSpace = "02843";
            var query = new SearchQuery(randomSearchSpace, queryContainedInSearchSpace);

            bool result = Search.ContainsString(query);

            Assert.IsTrue(result);
        }
    }

    [TestFixture]
    public class Search_TestFindString
    {
        [Test, Order(1)]
        public void FindString_QueryNotContainedInSearchSpace()
        {
            var searchSpace = "21+e921ur24hgfwneodjqlnv+r4039t530yt834";
            var query = " ";
            var queryRecord = new SearchQuery(searchSpace, query);
            var expectedSearchResultList = new List<SearchQuery>();

            var result = Search.FindString(queryRecord);

            Assert.AreEqual(expectedSearchResultList, result);

        }

        [Test, Order(2)]
        public void FindString_SingleCharacter_QueryContainedInSearchSpaceOnce()
        {
            var searchSpace = "21+e921ur24hgfwneodjqlnv+r4039t530yt834";
            var query = "f";
            var expectedSearchRecord1 = new SearchQuery("", query, 13, 14);
            var queryRecord = new SearchQuery(searchSpace, query);
            var expectedSearchResultList = new List<SearchQuery> {
                expectedSearchRecord1
            };

            var result = Search.FindString(queryRecord);

            Assert.AreEqual(expectedSearchResultList, result);
        }

        [Test, Order(3)]
        public void FindString_SingleCharacter_QueryContainedInSearchSpaceMultipleTimes()
        {
            var searchSpace = "21+e921ur24hgfwneodjqlnv+r4039t530yt834";
            var query = "+";
            var expectedSearchRecord1 = new SearchQuery("", query, 2, 3);
            var expectedSearchRecord2 = new SearchQuery("", query, 24, 25);
            var queryRecord = new SearchQuery(searchSpace, query);
            var expectedSearchResultList = new List<SearchQuery> {
                expectedSearchRecord1, expectedSearchRecord2
            };

            var result = Search.FindString(queryRecord);

            Assert.AreEqual(expectedSearchResultList, result);
        }

        [Test, Order(4)]
        public void FindString_String_QueryContainedInSearchSpaceOnce()
        {
            var searchSpace = "21+e921ur24hgfwneodjqlnv+r4039t530yt834";
            var query = "ur24";
            var expectedSearchRecord1 = new SearchQuery("", query, 7, 11);
            var queryRecord = new SearchQuery(searchSpace, query);
            var expectedSearchResultList = new List<SearchQuery> {
                expectedSearchRecord1
            };

            var result = Search.FindString(queryRecord);

            Assert.AreEqual(expectedSearchResultList, result);
        }

        [Test, Order(5)]
        public void FindString_String_QueryContainedInSearchSpaceMultipleTimes()
        {
            var searchSpace = "21+e921ur24hgfwneodjqlnv+r4039t530yt834";
            var query = "21";
            var expectedSearchRecord1 = new SearchQuery("", query, 0, 2);
            var expectedSearchRecord2 = new SearchQuery("", query, 5, 7);
            var queryRecord = new SearchQuery(searchSpace, query);
            var expectedSearchResultList = new List<SearchQuery> {
                expectedSearchRecord1, expectedSearchRecord2
            };

            var result = Search.FindString(queryRecord);

            Assert.AreEqual(expectedSearchResultList, result);
        }

        [Test, Order(6)]
        public void FindString_QueryPrefixFoundAtTheEndOfSearchSpace()
        {
            var searchSpace = "21+e921ur24hgfwneodjqlnv+r4039t530yt834";
            var query = "3472";
            var queryRecord = new SearchQuery(searchSpace, query);
            var expectedSearchResultList = new List<SearchQuery>();

            var result = Search.FindString(queryRecord);

            Assert.AreEqual(expectedSearchResultList, result);
        }
    }

    [TestFixture]
    public class Search_TestGenericWildcardSearch
    {
        string wildcardString = Search.wildcardToken;

        [Test, Order(1)]
        public void GenericWildcardSearch_SearchWithWildcardOnly()
        {
            var searchQuery = wildcardString;
            //var searchRecord = new SearchRecord();
        }

        [Test, Order(2)]
        public void GenericWildcardSearch_SearchWithoutWildcard()
        {

        }

        [Test, Order(3)]
        public void GenericWildcardSearch_SearchWithSingleWildcard()
        {

        }

        [Test, Order(4)]
        public void GenericWildcardSearch_SearchWithMultipleWildcards()
        {

        }

        [Test, Order(5)]
        public void GenericWildcardSearch_WildcardPlacedAtTheStartOfSearchQuery()
        {

        }

        [Test, Order(6)]
        public void GenericWildcardSearch_WildcardPlacedAtTheEndOfSearchQuery()
        {

        }

        [Test, Order(7)]
        public void GenericWildcardSearch_TwoWildcardsPlacedConsecutively()
        {

        }
    }

    [TestFixture]
    public class Search_TestSemanticWildcardSearch
    {

    }
}