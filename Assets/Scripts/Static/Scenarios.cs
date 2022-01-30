using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Scenarios
{
    public enum Scenario
    {
        BULLIED_MIDDLE,
        BULLIED_HIGH,
        REJECTED_ART_SCHOOL,
        REJECTED_WOMEN
    }
    public enum Choice
    {
        DEAL,
        STAND_UP,
        FIND_OUTLET,
        MAKE_FRIENDS
    }
    public enum Outcome
    {
        SUICIDE,
        MOVE_ON,
        SCHOOL_FIGHT,
        SCHOOL_SHOOTER,
        HITLER,
        BUNDY,
        DRUG_ADDICT,
        DRUG_DEALER
    }

    public enum Matches
    {
        BM_DEAL,
        BM_SU,
        BM_FO,
        BM_MF,
        BH_DEAL,
        BH_SU,
        BH_FO,
        BH_MF,
        RA_DEAL,
        RA_SU,
        RA_FO,
        RA_MF,
        RW_DEAL,
        RW_SU,
        RW_FO,
        RW_MF
    }

    public struct Character
    {
        bool hasFriends;
        bool hasOutlet;
        bool hasStoodUp;
        bool hasDealt;
        public Character(bool friends, bool outlet, bool stoodUp, bool dealt)
        {
            this.hasFriends = friends;
            this.hasOutlet = outlet;
            this.hasStoodUp = stoodUp;
            this.hasDealt = dealt;
        }
    }

    public static readonly Dictionary<Matches, Outcome> HarshOutcomes = new Dictionary<Matches, Outcome>
    {
        { Matches.BM_DEAL, Outcome.MOVE_ON },
        { Matches.BM_SU, Outcome.SCHOOL_FIGHT },
        { Matches.BM_FO, Outcome.MOVE_ON },
        { Matches.BM_MF, Outcome.MOVE_ON },
        { Matches.BH_DEAL, Outcome.SUICIDE },
        { Matches.BH_SU, Outcome.SCHOOL_SHOOTER },
        { Matches.BH_FO, Outcome.MOVE_ON },
        { Matches.BH_MF, Outcome.MOVE_ON },

    };
}