using System;
using TheCartelKata.Factory;

namespace TheCartelKata
{
    /*
     * An infamous drug cartel have contacted you to build a system for them
     * the system needs to handle three major areas of their trade:
     *      1. Production
     *      2. Stock
     *      3. Distribution
     * of the following drugs
     *  Marijuana
     *      Morthern Lights
     *      Purple Haze
     *      White Widow
     *  Cocaine
     *      % different purities
     *          high 90%
     *          medium 75%
     *          low 60%
     *  MDMA
     *      5g, 10g, 15g
     *      Brand (star, alien, joker)
     *
     * For production:
     * Store a collecction of properties these can vary between
     *      1. Rural
     *      2. Jungle
     *      3. Urban
     * and each property has a size
     *      1. Rural in ha (hectare)
     *      2. Jungle in ha (hectare)
     *      3. Urban in m^2 (square meter)
     *
     * Rural properties can manufacture Marijuana
     * Jungle properties can manufacture Cocaine
     * Urban properties can manufacture MDMA
     *
     * Note:
     *  Marijuana has a strain (sativa or indica)
     *  Cocain has a purity (in %)
     *  MDMA has a symbol (joker, alien, star) and a pill weight (in grams)
     *
     * Once all of the properties have been processed and stored
     * the system needs to calculate the production over a given time period
     * the production is dependent on the drug, size of property, as well as the time period
     *
     * Production per area is given by the following:
     *      1ha = 10kg marijuana a month
     *      1ha = 100kg cocaine every 2 weeks
     *      10m^2 = 50 MDMA pills a week
     *
     * Storage:
     *
     * The system needs to take stock, and generate a report of the total value
     * of each of the drugs, as well as a combined value, in two states:
     *  Raw:
     *      mj = $100/kg
     *      coke = $10000/kg
     *      mgma $10/pill
     *  Cut (only Cocaine can be cut):
     *      light $12000/kg
     *      medium $14000/kg
     *      heavy $16000/kg
     *
     * Distribution:
     *
     * The system needs to handle distribution.
     * A King Pin distributes to a Distributor
     * A Distributor distributes to a Street Dealer
     *
     * A King Pin handles transactions above $10000
     * A Distributor handles transactions above $1000 and below $10000
     * A Street Dealer handles transactions below $1000
     *
     * All transactions must first take place through a Street Dealer
     *
     * To fullfil the kata you will need to:
     *  1. Use proper TDD, and create the proper tests
     *  2. Use Abstract Factory, Factory, Strategy and Chain of Command patterns
     */

    internal class Program
    {

        private static void Main()
        {
            var days = 15;
            foreach (var key in PropertyFactory.Properties.Keys)
            {
                var property = PropertyFactory.Properties[key]();
                property.Produce(days);
                Console.WriteLine($"Producing {property.Drug.Name} in {days} days");
                Console.WriteLine($"{property.Storage.Units.ToString("#0.00")}{property.Drug.Unit} of {property.Drug.Name} in storage");
                Console.WriteLine($"Total cost of storage {property.Storage.GetPrice().ToString("$0.00")}");
            }

            Console.ReadKey();
        }
    }
}
