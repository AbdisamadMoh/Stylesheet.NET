using System;

namespace StylesheetNET
{
    [Flags]
    public enum PseudoType
    {
        None = 0,

        // Pseudo Classes
        Enabled = 1,
        Disabled = 2,
        Hover = 3,
        Valid = 4,
        Invalid = 5,
        ReadOnly = 6,
        ReadWrite = 7,
        InRange = 8,
        OutOfRange = 9,
        FirstChild = 10,
        LastChild = 11,
        FirstOfType = 12,
        LastOfType = 13,
        NthChild = 14,
        NthLastChild = 15,
        NthOfType = 16,
        NthLastOfType = 17,
        Link = 18,
        Visited = 19,
        OnlyChild = 20,
        OnlyOfType = 21,
        Active = 22,
        Checked = 23,
        Empty = 24,
        Focus = 25,
        Lang = 26,
        Not = 27,
        Required = 28,
        Target = 29,

        // Pseudo Elements
        After = 30,
        Before = 31,
        FirstLetter = 32,
        FirstLine = 33,
        Marker = 34,
        Selection = 35,

        // Groupings
        PseudoClasses = Enabled | Disabled | Hover | Valid | Invalid | ReadOnly | ReadWrite |
                        InRange | OutOfRange | FirstChild | LastChild | FirstOfType | LastOfType |
                        NthChild | NthLastChild | NthOfType | NthLastOfType | Link | Visited | OnlyChild |
                        OnlyOfType | Active | Checked | Empty | Focus | Lang | Not | Required | Target,

        PseudoElements = After | Before | FirstLetter | FirstLine | Marker | Selection,
        AllPseudos = PseudoClasses | PseudoElements
    }


}
