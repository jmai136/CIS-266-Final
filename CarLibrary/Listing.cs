using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Listing
    {
        // should have the properties for Car and the DateTime of the creation of the listing
        // Grab subclass of car?
        DateTime carCreationTime { get; set; }

        /*
         * Change the code so you use Interfaces instead.
         * Create your own custom interfaces.
         * Use the in-built interfaces that help you compare different listings while filtering.
         * (Hint: IComparable)
         */

        // Select statements here or grab the query created in the designer
        // Should have all three methods somewhere: creating query through designer, execute scalar, and stored procedures
        public static void GetAllCars()
        {
           
        }

        // Insert in the parameters here

        /*
         * When a filter option is selected, the application should show subsections with
         * titles in ascending order.
         * The titles can include the different makes in ascending order if make is
         * selected. Then display appropriate car listings underneath each title
         * ordered by listings' creation times.
         * There is no need to filter by model so you can skip that.
         * If color is selected, figure out how many different colors are in your saved
         * car listings data and create that many subsections with titles as those
         * colors in ascending order. Then display the cars under the appropriate
         * color ordered by listings' creation times.
         * 
         * The age and price should have ranges. For example: price under $5000,
         * between $5000 to $9,999, and $10,000+ as the titles for the subsections.
         * Then display the appropriate car listings in those subsections ordered by
         * listings' creation times. 
         */
        public static void GetCarFilteredBy()
        {

        }

        public static void UploadCarListing()
        {

        }

        public static void DeleteCarListing()
        {

        }

        // Comment section where a potential buyer can ask questions to the seller.
        // Save in text file?
        public static void GetComment()
        {

        }
    }

    public interface IListing
    {
    }
}
