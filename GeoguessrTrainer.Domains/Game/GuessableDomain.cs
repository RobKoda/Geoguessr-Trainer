﻿

// ReSharper disable StringLiteralTypo - Country names

namespace GeoguessrTrainer.Domains.Game;

public sealed record GuessableDomain(string Country, string Domain)
{
    public static readonly IList<GuessableDomain> List = new List<GuessableDomain>
    {
        new("Botswana", ".bw"),
        new("Eswatini", ".sz"),
        new("Ghana", ".gh"),
        new("Kenya", ".ke"),
        new("Lesotho", ".ls"),
        new("Madagascar", ".mg"),
        new("Nigeria", ".ng"),
        new("Senegal", ".sn"),
        new("South Africa", ".za"),
        new("Tunisia", ".tn"),
        new("Uganda", ".ug"),
        new("Bangladesh", ".bd"),
        new("Bhutan", ".bt"),
        new("Cambodia", ".kh"),
        new("Christmas Island", ".cx"),
        new("India", ".in"),
        new("Indonesia", ".id"),
        new("Israel", ".il"),
        new("Japan", ".jp"),
        new("Jordan", ".jo"),
        new("Kyrgyzstan", ".kg"),
        new("Laos", ".la"),
        new("Malaysia", ".my"),
        new("Mongolia", ".mn"),
        new("Philippines", ".ph"),
        new("Russia", ".ru"),
        new("Singapore", ".sg"),
        new("South Korea", ".kr"),
        new("Sri Lanka", ".lk"),
        new("Taiwan", ".tw"),
        new("Thailand", ".th"),
        new("United Arab Emirates", ".ae"),
        new("Vietnam", ".vn"),
        new("Albania", ".al"),
        new("Andorra", ".ad"),
        new("Austria", ".at"),
        new("Belgium", ".be"),
        new("Bulgaria", ".bg"),
        new("Croatia", ".hr"),
        new("Czech Republic", ".cz"),
        new("Denmark", ".dk"),
        new("Estonia", ".ee"),
        new("Faroe Islands", ".fo"),
        new("Finland", ".fi"),
        new("France", ".fr"),
        new("Germany", ".de"),
        new("Gibraltar", ".gi"),
        new("Greece", ".gr"),
        new("Hungary", ".hu"),
        new("Iceland", ".is"),
        new("Ireland", ".ie"),
        new("Isle of Man", ".im"),
        new("Italy", ".it"),
        new("Jersey", ".je"),
        new("Latvia", ".lv"),
        new("Lithuania", ".lt"),
        new("Luxembourg", ".lu"),
        new("Malta", ".mt"),
        new("Monaco", ".mc"),
        new("Montenegro", ".me"),
        new("Netherlands", ".nl"),
        new("North Macedonia", ".mk"),
        new("Norway", ".no"),
        new("Poland", ".pl"),
        new("Portugal", ".pt"),
        new("Romania", ".ro"),
        new("San Marino", ".sm"),
        new("Serbia", ".rs"),
        new("Slovakia", ".sk"),
        new("Slovenia", ".si"),
        new("Spain", ".es"),
        new("Sweden", ".se"),
        new("Switzerland", ".ch"),
        new("Turkey", ".tr"),
        new("Ukraine", ".ua"),
        new("United Kingdom", ".uk"),
        new("Canada", ".ca"),
        new("Curaçao", ".cw"),
        new("Dominican Republic", ".do"),
        new("Greenland", ".gl"),
        new("Guatemala", ".gt"),
        new("Mexico", ".mx"),
        new("Puerto Rico", ".pr"),
        new("United States", ".us"),
        new("US Virgin Islands", ".vi"),
        new("American Samoa", ".as"),
        new("Australia", ".au"),
        new("Guam", ".gu"),
        new("New Zealand", ".nz"),
        new("Northern Mariana Islands", ".mp"),
        new("Argentina", ".ar"),
        new("Bolivia", ".bo"),
        new("Brazil", ".br"),
        new("Chile", ".cl"),
        new("Colombia", ".co"),
        new("Ecuador", ".ec"),
        new("Peru", ".pe"),
        new("Uruguay", ".uy")
    };
}