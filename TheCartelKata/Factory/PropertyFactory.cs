using System;
using System.Collections.Generic;
using TheCartelKata.Enum;

namespace TheCartelKata.Factory
{
    public static class PropertyFactory
    {
        public static readonly double JungleTimeUnits = 14;
        public static readonly double JungleWeightUnits = 100;

        public static readonly double RuralTimeUnits = 30;
        public static readonly double RuralWeightUnits = 10;

        public static readonly double UrbanTimeUnits = 7;
        public static readonly double UrbanWeightUnits = 50;

        public static Dictionary<string, Func<Property>> Properties = new Dictionary<string, Func<Property>>
        {
            { "Johannesburg", () => { return new UrbanProperty(new Mdma(), 165, UrbanTimeUnits, UrbanWeightUnits); } },
            { "Pretoria", () => { return new UrbanProperty(new Mdma(), 69, UrbanTimeUnits, UrbanWeightUnits); } },
            { "Knysna", () => { return new JungleProperty(new Cocaine(), 110, JungleTimeUnits, JungleWeightUnits); } },
            { "Jumanji", () => { return new JungleProperty(new Cocaine { State = State.Cut, Cut = Cut.Medium }, 110, JungleTimeUnits, JungleWeightUnits); } },
            { "Muldersdrift", () => { return new RuralProperty(new Marijuana(), 7.499997387, RuralTimeUnits, RuralWeightUnits); } },
        };
    }
}
