using System.Collections.Generic;
using Godot;
using YKnyttLib;

public static class GDKnyttObjectFactory
{
    private static Dictionary<KnyttPoint, string> ObjectLookup;

    static GDKnyttObjectFactory()
    {
        ObjectLookup = new Dictionary<KnyttPoint, string>();
        ObjectLookup[new KnyttPoint(0, 1)]  =  "SavePoint";
        ObjectLookup[new KnyttPoint(0, 2)]  =  "Win";
        ObjectLookup[new KnyttPoint(0, 3)]  =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 4)]  =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 5)]  =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 6)]  =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 7)]  =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 8)]  =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 9)]  =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 10)] =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 11)] =  "NoClimb";
        ObjectLookup[new KnyttPoint(0, 13)] =  "Sticky";
        ObjectLookup[new KnyttPoint(0, 14)] =  "Shift";
        ObjectLookup[new KnyttPoint(0, 15)] =  "Shift";
        ObjectLookup[new KnyttPoint(0, 16)] =  "Shift";
        ObjectLookup[new KnyttPoint(0, 17)] =  "Sign";
        ObjectLookup[new KnyttPoint(0, 18)] =  "Sign";
        ObjectLookup[new KnyttPoint(0, 19)] =  "Sign";
        ObjectLookup[new KnyttPoint(0, 20)] =  "Warp";
        ObjectLookup[new KnyttPoint(0, 21)] =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 22)] =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 23)] =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 24)] =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 25)] =  "NoJump";
        ObjectLookup[new KnyttPoint(0, 26)] =  "EnemyDetector";
        ObjectLookup[new KnyttPoint(0, 27)] =  "SecretDetector";
        ObjectLookup[new KnyttPoint(0, 28)] =  "SecretDetector";
        ObjectLookup[new KnyttPoint(0, 29)] =  "SignArea";
        ObjectLookup[new KnyttPoint(0, 30)] =  "SignArea";
        ObjectLookup[new KnyttPoint(0, 31)] =  "SignArea";
        ObjectLookup[new KnyttPoint(0, 32)] =  "Trigger";
        ObjectLookup[new KnyttPoint(0, 33)] =  "Trigger";
        ObjectLookup[new KnyttPoint(0, 34)] =  "Trigger";
        ObjectLookup[new KnyttPoint(0, 35)] =  "PowerItem";
        ObjectLookup[new KnyttPoint(0, 36)] =  "Title";
        ObjectLookup[new KnyttPoint(0, 42)] =  "SpawnPoint";
        ObjectLookup[new KnyttPoint(0, 43)] =  "SpawnPoint";
        ObjectLookup[new KnyttPoint(0, 44)] =  "SpawnPoint";
        ObjectLookup[new KnyttPoint(0, 45)] =  "DeletePoint";
        ObjectLookup[new KnyttPoint(0, 46)] =  "DeletePoint";
        ObjectLookup[new KnyttPoint(0, 47)] =  "DeletePoint";
        ObjectLookup[new KnyttPoint(0, 247)] = "BlockUser";
        ObjectLookup[new KnyttPoint(0, 248)] = "Automation";
        ObjectLookup[new KnyttPoint(0, 249)] = "Automation";
        ObjectLookup[new KnyttPoint(0, 250)] = "Automation";
        ObjectLookup[new KnyttPoint(0, 251)] = "Automation";
        ObjectLookup[new KnyttPoint(0, 252)] = "Automation";
        ObjectLookup[new KnyttPoint(0, 253)] = "Automation";
        ObjectLookup[new KnyttPoint(0, 254)] = "Automation";
        ObjectLookup[new KnyttPoint(0, 255)] = "Automation";
        ObjectLookup[new KnyttPoint(1, 1)] =   "LiquidPool";
        ObjectLookup[new KnyttPoint(1, 2)] =   "LiquidPool";
        ObjectLookup[new KnyttPoint(1, 3)] =   "Waterfall";
        ObjectLookup[new KnyttPoint(1, 4)] =   "Waterfall";
        ObjectLookup[new KnyttPoint(1, 5)] =   "LiquidPool";
        ObjectLookup[new KnyttPoint(1, 6)] =   "LiquidPool";
        ObjectLookup[new KnyttPoint(1, 7)] =   "WaterBlock";
        ObjectLookup[new KnyttPoint(1, 8)] =   "WaterBlock";
        ObjectLookup[new KnyttPoint(1, 9)] =   "WaterBlock";
        ObjectLookup[new KnyttPoint(1, 10)] =  "LiquidPool";
        ObjectLookup[new KnyttPoint(1, 11)] =  "WaterBlock";
        ObjectLookup[new KnyttPoint(1, 12)] =  "LiquidPool";
        ObjectLookup[new KnyttPoint(1, 13)] =  "LiquidPool";
        ObjectLookup[new KnyttPoint(1, 14)] =  "LiquidPool";
        ObjectLookup[new KnyttPoint(1, 15)] =  "Waterfall";
        ObjectLookup[new KnyttPoint(1, 16)] =  "LiquidPool";
        ObjectLookup[new KnyttPoint(1, 17)] =  "WaterBlock";
        ObjectLookup[new KnyttPoint(1, 18)] =  "Bubble";
        ObjectLookup[new KnyttPoint(1, 19)] =  "LiquidPool";
        ObjectLookup[new KnyttPoint(1, 20)] =  "Waterfall";
        ObjectLookup[new KnyttPoint(1, 21)] =  "WaterBlock";
        ObjectLookup[new KnyttPoint(1, 22)] =  "LiquidPool";
        ObjectLookup[new KnyttPoint(1, 23)] =  "Waterfall";
        ObjectLookup[new KnyttPoint(1, 24)] =  "WaterBlock";
        ObjectLookup[new KnyttPoint(2, 15)] =  "BuzzFlyer";
        ObjectLookup[new KnyttPoint(2, 16)] =  "BuzzFlyer";
        ObjectLookup[new KnyttPoint(2, 17)] =  "BuzzFlyer";
        ObjectLookup[new KnyttPoint(2, 18)] =  "YellowElemental";
        ObjectLookup[new KnyttPoint(2, 19)] =  "RedElemental";
        ObjectLookup[new KnyttPoint(2, 20)] =  "FlySpike1";
        ObjectLookup[new KnyttPoint(2, 21)] =  "FlySpike2";
        ObjectLookup[new KnyttPoint(2, 28)] =  "Birdie3";
        ObjectLookup[new KnyttPoint(2, 30)] =  "CircleBird";
        ObjectLookup[new KnyttPoint(3, 1)] =   "Muff1";
        ObjectLookup[new KnyttPoint(3, 2)] =   "RollerMuff2";
        ObjectLookup[new KnyttPoint(3, 3)] =   "Muff3";
        ObjectLookup[new KnyttPoint(3, 4)] =   "SpikerMuff4";
        ObjectLookup[new KnyttPoint(3, 5)] =   "YellowDog";
        ObjectLookup[new KnyttPoint(3, 6)] =   "SpikerMuff6";
        ObjectLookup[new KnyttPoint(3, 7)] =   "Muff7";
        ObjectLookup[new KnyttPoint(3, 8)] =   "RollerMuff8";
        ObjectLookup[new KnyttPoint(3, 9)] =   "Muff9";
        ObjectLookup[new KnyttPoint(3, 10)] =  "Muff10";
        ObjectLookup[new KnyttPoint(3, 11)] =  "Muff11";
        ObjectLookup[new KnyttPoint(3, 12)] =  "Eskimo1";
        ObjectLookup[new KnyttPoint(3, 13)] =  "Eskimo2";
        ObjectLookup[new KnyttPoint(3, 14)] =  "LookMuff14";
        ObjectLookup[new KnyttPoint(3, 15)] =  "Muff15";
        ObjectLookup[new KnyttPoint(3, 16)] =  "Muff16";
        ObjectLookup[new KnyttPoint(3, 17)] =  "Muff17";
        ObjectLookup[new KnyttPoint(3, 18)] =  "Muff18";
        ObjectLookup[new KnyttPoint(3, 19)] =  "Muff19";
        ObjectLookup[new KnyttPoint(3, 20)] =  "Muff20";
        ObjectLookup[new KnyttPoint(3, 21)] =  "BeardGuy";
        ObjectLookup[new KnyttPoint(3, 22)] =  "SpikerMuff22";
        ObjectLookup[new KnyttPoint(3, 23)] =  "Muff23";
        ObjectLookup[new KnyttPoint(3, 24)] =  "Muff24";
        ObjectLookup[new KnyttPoint(3, 25)] =  "Ratlike";
        ObjectLookup[new KnyttPoint(3, 26)] =  "LookMuff26";
        ObjectLookup[new KnyttPoint(3, 27)] =  "ForestDude";
        ObjectLookup[new KnyttPoint(3, 28)] =  "Muff28";
        ObjectLookup[new KnyttPoint(3, 29)] =  "SkyGirl";
        ObjectLookup[new KnyttPoint(3, 30)] =  "Muff30";
        ObjectLookup[new KnyttPoint(3, 31)] =  "Muff31";
        ObjectLookup[new KnyttPoint(3, 32)] =  "FlyGirl";
        ObjectLookup[new KnyttPoint(3, 33)] =  "SpikerMuff33";
        ObjectLookup[new KnyttPoint(3, 34)] =  "Muff34";
        ObjectLookup[new KnyttPoint(3, 35)] =  "Muff35";
        ObjectLookup[new KnyttPoint(3, 36)] =  "Muff36";
        ObjectLookup[new KnyttPoint(3, 37)] =  "Baby";
        ObjectLookup[new KnyttPoint(3, 38)] =  "LookMuff38";
        ObjectLookup[new KnyttPoint(3, 39)] =  "CaveDude";
        ObjectLookup[new KnyttPoint(3, 40)] =  "Muff40";
        ObjectLookup[new KnyttPoint(3, 41)] =  "LookMuff41";
        ObjectLookup[new KnyttPoint(3, 42)] =  "BigCat";
        ObjectLookup[new KnyttPoint(3, 43)] =  "SmallCat";
        ObjectLookup[new KnyttPoint(3, 44)] =  "Muff44";
        ObjectLookup[new KnyttPoint(4, 1)] =   "CircleCrawler";
        ObjectLookup[new KnyttPoint(4, 2)] =   "SideCrawler";
        ObjectLookup[new KnyttPoint(4, 3)] =   "SixLeg";
        ObjectLookup[new KnyttPoint(4, 4)] =   "SixLegChild";
        ObjectLookup[new KnyttPoint(4, 5)] =   "SixLegBaby";
        ObjectLookup[new KnyttPoint(4, 6)] =   "FloorDropCrawler";
        ObjectLookup[new KnyttPoint(4, 7)] =   "CeilingDropCrawler";
        ObjectLookup[new KnyttPoint(4, 8)] =   "SlowSideCrawler";
        ObjectLookup[new KnyttPoint(4, 9)] =   "BigSpider";
        ObjectLookup[new KnyttPoint(4, 10)] =  "LeftStranger";
        ObjectLookup[new KnyttPoint(4, 11)] =  "RightStranger";
        ObjectLookup[new KnyttPoint(4, 12)] =  "StrangeRunner";
        ObjectLookup[new KnyttPoint(4, 13)] =  "SideCrawler2";
        ObjectLookup[new KnyttPoint(4, 14)] =  "TriLegSpider";
        ObjectLookup[new KnyttPoint(4, 15)] =  "AnotherStrangeRunner";
        ObjectLookup[new KnyttPoint(4, 16)] =  "HomingRunner";
        ObjectLookup[new KnyttPoint(4, 17)] =  "Hedgehog";
        ObjectLookup[new KnyttPoint(4, 18)] =  "ToastMonsterNew";
        ObjectLookup[new KnyttPoint(4, 19)] =  "TriShot";
        ObjectLookup[new KnyttPoint(4, 20)] =  "FiveShot";
        ObjectLookup[new KnyttPoint(4, 21)] =  "RightSuperStranger";
        ObjectLookup[new KnyttPoint(4, 22)] =  "LeftSuperStranger";
        ObjectLookup[new KnyttPoint(5, 1)] =   "ShadowWitch";
        ObjectLookup[new KnyttPoint(5, 2)] =   "ShadowBoy";
        ObjectLookup[new KnyttPoint(5, 3)] =   "ShadowGirl";
        ObjectLookup[new KnyttPoint(6, 1)] =   "TrapCeiling";
        ObjectLookup[new KnyttPoint(6, 2)] =   "LabyrinthSpike";
        ObjectLookup[new KnyttPoint(6, 3)] =   "RandomLabyrinthSpike";
        ObjectLookup[new KnyttPoint(6, 4)] =   "FastLabyrinthSpike";
        ObjectLookup[new KnyttPoint(6, 5)] =   "Eater";
        ObjectLookup[new KnyttPoint(6, 6)] =   "TrapFire";
        ObjectLookup[new KnyttPoint(6, 7)] =   "DownStuffShooter";
        ObjectLookup[new KnyttPoint(6, 8)] =   "SelfDropper";
        ObjectLookup[new KnyttPoint(6, 9)] =   "UpStuffShooter";
        ObjectLookup[new KnyttPoint(6, 10)] =  "UpSpikes";
        ObjectLookup[new KnyttPoint(6, 11)] =  "DownSpikes";
        ObjectLookup[new KnyttPoint(6, 12)] =  "LeftSpikes";
        ObjectLookup[new KnyttPoint(6, 13)] =  "RightSpikes";
        ObjectLookup[new KnyttPoint(6, 14)] =  "UpPermanentSpikes";
        ObjectLookup[new KnyttPoint(6, 15)] =  "DownPermanentSpikes";
        ObjectLookup[new KnyttPoint(6, 16)] =  "LeftPermanentSpikes";
        ObjectLookup[new KnyttPoint(6, 17)] =  "RightPermanentSpikes";
        ObjectLookup[new KnyttPoint(7, 1)] =   "Leaf";
        ObjectLookup[new KnyttPoint(7, 5)] =   "SunRay";
        ObjectLookup[new KnyttPoint(7, 6)] =   "Leaf";
        ObjectLookup[new KnyttPoint(7, 8)] =   "Rain";
        ObjectLookup[new KnyttPoint(7, 9)] =   "RaindropObject";
        ObjectLookup[new KnyttPoint(7, 10)] =  "Leaf";
        ObjectLookup[new KnyttPoint(7, 12)] =  "Leaf";
        ObjectLookup[new KnyttPoint(7, 14)] =  "Dust";
        ObjectLookup[new KnyttPoint(7, 15)] =  "Dust";
        ObjectLookup[new KnyttPoint(7, 16)] =  "Cloud";
        ObjectLookup[new KnyttPoint(8, 1)] =   "HorizontalConnection";
        ObjectLookup[new KnyttPoint(8, 2)] =   "VerticalConnection";
        ObjectLookup[new KnyttPoint(8, 3)] =   "LampLeft";
        ObjectLookup[new KnyttPoint(8, 4)] =   "LampMid";
        ObjectLookup[new KnyttPoint(8, 5)] =   "LampRight";
        ObjectLookup[new KnyttPoint(8, 6)] =   "SimpleDecoration";
        ObjectLookup[new KnyttPoint(8, 7)] =   "SimpleDecoration";
        ObjectLookup[new KnyttPoint(8, 8)] =   "TinyFire";
        ObjectLookup[new KnyttPoint(8, 9)] =   "SimpleDecoration";
        ObjectLookup[new KnyttPoint(8, 10)] =  "Star";
        ObjectLookup[new KnyttPoint(8, 11)] =  "MachinePart1";
        ObjectLookup[new KnyttPoint(8, 12)] =  "SimpleDecoration";
        ObjectLookup[new KnyttPoint(8, 13)] =  "MachinePart3";
        ObjectLookup[new KnyttPoint(8, 14)] =  "MachinePart4";
        ObjectLookup[new KnyttPoint(8, 15)] =  "Explosion";
        ObjectLookup[new KnyttPoint(9, 1)] =   "RedTrapFlower";
        ObjectLookup[new KnyttPoint(9, 2)] =   "TimedFlower";
        ObjectLookup[new KnyttPoint(9, 3)] =   "HomingFlower";
        ObjectLookup[new KnyttPoint(9, 4)] =   "AgressiveTrapFlower";
        ObjectLookup[new KnyttPoint(9, 5)] =   "SmallTimedFlower";
        ObjectLookup[new KnyttPoint(10, 1)] =  "Bouncer1";
        ObjectLookup[new KnyttPoint(10, 2)] =  "Bouncer2";
        ObjectLookup[new KnyttPoint(10, 3)] =  "Cauldron";
        ObjectLookup[new KnyttPoint(10, 5)] =  "BouncerEnemy";
        ObjectLookup[new KnyttPoint(10, 8)] =  "BouncerGreen";
        ObjectLookup[new KnyttPoint(10, 9)] =  "BigFluff";
        ObjectLookup[new KnyttPoint(10, 10)] = "HappyFluff";
        ObjectLookup[new KnyttPoint(10, 11)] = "OldFluff";
        ObjectLookup[new KnyttPoint(10, 12)] = "RegularFluff";
        ObjectLookup[new KnyttPoint(10, 13)] = "TeenageFluff";
        ObjectLookup[new KnyttPoint(11, 1)] =  "RedDisk";
        ObjectLookup[new KnyttPoint(11, 2)] =  "ShockDisk1";
        ObjectLookup[new KnyttPoint(11, 3)] =  "PurpleDisk";
        ObjectLookup[new KnyttPoint(11, 4)] =  "PurpleSpikedDisk";
        ObjectLookup[new KnyttPoint(11, 5)] =  "RedSpikedDisk";
        ObjectLookup[new KnyttPoint(11, 6)] =  "ShockDisk2";
        ObjectLookup[new KnyttPoint(11, 7)] =  "AnotherDisk";
        ObjectLookup[new KnyttPoint(11, 8)] =  "GreenDisk";
        ObjectLookup[new KnyttPoint(11, 9)] =  "ShockDisk3";
        ObjectLookup[new KnyttPoint(11, 10)] = "YellowDisk";
        ObjectLookup[new KnyttPoint(11, 11)] = "YellowDisk2";
        ObjectLookup[new KnyttPoint(12, 3)] =  "GhostMufs";
        ObjectLookup[new KnyttPoint(12, 4)] =  "AnotherGhost";
        ObjectLookup[new KnyttPoint(12, 5)] =  "GhostBlock";
        ObjectLookup[new KnyttPoint(12, 7)] =  "AnotherGhost2";
        ObjectLookup[new KnyttPoint(12, 8)] =  "GhostMiner";
        ObjectLookup[new KnyttPoint(12, 9)] =  "GroundBlob";
        ObjectLookup[new KnyttPoint(12, 10)] = "GhostEater";
        ObjectLookup[new KnyttPoint(12, 11)] = "Ghost";
        ObjectLookup[new KnyttPoint(12, 13)] = "GhostCrawler";
        ObjectLookup[new KnyttPoint(12, 17)] = "NoWall";
        ObjectLookup[new KnyttPoint(12, 18)] = "GhostMarker18";
        ObjectLookup[new KnyttPoint(12, 19)] = "GhostMarker19";
        ObjectLookup[new KnyttPoint(12, 20)] = "GhostMarker20";
        ObjectLookup[new KnyttPoint(12, 21)] = "GhostMarker21";
        ObjectLookup[new KnyttPoint(13, 1)] =  "RobotCannon";
        ObjectLookup[new KnyttPoint(13, 2)] =  "HomingCannon";
        ObjectLookup[new KnyttPoint(13, 3)] =  "LaserRobot";
        ObjectLookup[new KnyttPoint(13, 4)] =  "UpCannon";
        ObjectLookup[new KnyttPoint(13, 5)] =  "DropstuffRobot";
        ObjectLookup[new KnyttPoint(13, 6)] =  "RollerGenerator";
        ObjectLookup[new KnyttPoint(13, 7)] =  "Laser";
        ObjectLookup[new KnyttPoint(13, 8)] =  "Laser";
        ObjectLookup[new KnyttPoint(13, 9)] =  "Laser";
        ObjectLookup[new KnyttPoint(13, 10)] = "Laser";
        ObjectLookup[new KnyttPoint(13, 11)] = "Laser";
        ObjectLookup[new KnyttPoint(13, 12)] = "Laser";
        ObjectLookup[new KnyttPoint(13, 13)] = "FlyBot";
        ObjectLookup[new KnyttPoint(13, 14)] = "DarkHomingCannon";
        ObjectLookup[new KnyttPoint(14, 1)] =  "RedJelly";
        ObjectLookup[new KnyttPoint(14, 2)] =  "GreenWorm";
        ObjectLookup[new KnyttPoint(14, 3)] =  "Snail";
        ObjectLookup[new KnyttPoint(14, 4)] =  "OrangeWorm";
        ObjectLookup[new KnyttPoint(14, 5)] =  "BouncingRock";
        ObjectLookup[new KnyttPoint(14, 6)] =  "SimpleWorm";
        ObjectLookup[new KnyttPoint(14, 7)] =  "LargeBouncingRock";
        ObjectLookup[new KnyttPoint(14, 8)] =  "HarmlessInsect";
        ObjectLookup[new KnyttPoint(14, 9)] =  "DangerousInsect";
        ObjectLookup[new KnyttPoint(14, 10)] = "StationaryRock";
        ObjectLookup[new KnyttPoint(14, 11)] = "InsectWithoutShell";
        ObjectLookup[new KnyttPoint(14, 12)] = "SmileBall";
        ObjectLookup[new KnyttPoint(14, 13)] = "BigRunThing";
        ObjectLookup[new KnyttPoint(14, 14)] = "SmallRunThing";
        ObjectLookup[new KnyttPoint(14, 15)] = "AnotherSnail";
        ObjectLookup[new KnyttPoint(14, 16)] = "FloorSpiker";
        ObjectLookup[new KnyttPoint(14, 17)] = "SuperMarioAI";
        ObjectLookup[new KnyttPoint(14, 18)] = "CeilingSpiker";
        ObjectLookup[new KnyttPoint(14, 19)] = "HiddenSpiker";
        ObjectLookup[new KnyttPoint(14, 20)] = "SpikelessSpiker";
        ObjectLookup[new KnyttPoint(14, 21)] = "SuperShotCeiling";
        ObjectLookup[new KnyttPoint(14, 22)] = "SuperShotFloor";
        ObjectLookup[new KnyttPoint(14, 23)] = "SuperShotLeft";
        ObjectLookup[new KnyttPoint(14, 24)] = "SuperShotRight";
        ObjectLookup[new KnyttPoint(15, 1)] =  "Block1";
        ObjectLookup[new KnyttPoint(15, 2)] =  "Block2";
        ObjectLookup[new KnyttPoint(15, 3)] =  "Block3";
        ObjectLookup[new KnyttPoint(15, 4)] =  "Block4";
        ObjectLookup[new KnyttPoint(15, 5)] =  "Updraft";
        ObjectLookup[new KnyttPoint(15, 6)] =  "ProximityBlock";
        ObjectLookup[new KnyttPoint(15, 7)] =  "ProximityBlock";
        ObjectLookup[new KnyttPoint(15, 8)] =  "FalseBlock";
        ObjectLookup[new KnyttPoint(15, 9)] =  "FalseBlock9";
        ObjectLookup[new KnyttPoint(15, 10)] =  "FalseBlock10";
        ObjectLookup[new KnyttPoint(15, 11)] =  "FalseBlock11";
        ObjectLookup[new KnyttPoint(15, 12)] =  "LockBlock";
        ObjectLookup[new KnyttPoint(15, 13)] =  "Password";
        ObjectLookup[new KnyttPoint(15, 14)] =  "Password";
        ObjectLookup[new KnyttPoint(15, 15)] =  "Password";
        ObjectLookup[new KnyttPoint(15, 16)] =  "Password";
        ObjectLookup[new KnyttPoint(15, 17)] =  "Password";
        ObjectLookup[new KnyttPoint(15, 18)] =  "Password";
        ObjectLookup[new KnyttPoint(15, 19)] =  "Password";
        ObjectLookup[new KnyttPoint(15, 20)] =  "Password";
        ObjectLookup[new KnyttPoint(15, 21)] =  "Password";
        ObjectLookup[new KnyttPoint(15, 22)] =  "ClearBlock";
        ObjectLookup[new KnyttPoint(15, 23)] =  "LockBlockHorizontal";
        ObjectLookup[new KnyttPoint(15, 24)] =  "LockBlockVertical";
        ObjectLookup[new KnyttPoint(15, 25)] = "FadeBlock";
        ObjectLookup[new KnyttPoint(15, 26)] = "HoldButton";
        ObjectLookup[new KnyttPoint(15, 27)] = "RedDoor";
        ObjectLookup[new KnyttPoint(15, 28)] = "YellowDoor";
        ObjectLookup[new KnyttPoint(15, 29)] = "BlueDoor";
        ObjectLookup[new KnyttPoint(15, 30)] = "PurpleDoor";
        ObjectLookup[new KnyttPoint(15, 31)] = "CollectionDoor1";
        ObjectLookup[new KnyttPoint(15, 32)] = "CollectionDoor5";
        ObjectLookup[new KnyttPoint(15, 33)] = "CollectionDoor10";
        ObjectLookup[new KnyttPoint(15, 34)] = "CollectionDoor20";
        ObjectLookup[new KnyttPoint(15, 35)] = "CollectionDoor40";
        ObjectLookup[new KnyttPoint(15, 36)] = "CollectionDoor50";
        ObjectLookup[new KnyttPoint(15, 37)] = "Crumble37";
        ObjectLookup[new KnyttPoint(15, 38)] = "Crumble38";
        ObjectLookup[new KnyttPoint(16, 1)] =  "Spring";
        ObjectLookup[new KnyttPoint(16, 2)] =  "DeathZoneTop";
        ObjectLookup[new KnyttPoint(16, 3)] =  "DeathZoneBottom";
        ObjectLookup[new KnyttPoint(16, 4)] =  "DeathZoneRight";
        ObjectLookup[new KnyttPoint(16, 5)] =  "DeathZoneLeft";
        ObjectLookup[new KnyttPoint(16, 6)] =  "DeathZone";
        ObjectLookup[new KnyttPoint(16, 7)] =  "DeathZoneMiddleH";
        ObjectLookup[new KnyttPoint(16, 8)] =  "DeathZoneMiddleV";
        ObjectLookup[new KnyttPoint(16, 9)] =  "DeathZoneHalfRight";
        ObjectLookup[new KnyttPoint(16, 10)] =  "DeathZoneHalfUp";
        ObjectLookup[new KnyttPoint(16, 11)] =  "DeathZoneHalfLeft";
        ObjectLookup[new KnyttPoint(16, 12)] =  "DeathZoneHalfDown";
        ObjectLookup[new KnyttPoint(16, 13)] = "InvisibleBarrier";
        ObjectLookup[new KnyttPoint(16, 14)] = "InvisibleBlock";
        ObjectLookup[new KnyttPoint(16, 15)] = "InvisibleSlopeLeft";
        ObjectLookup[new KnyttPoint(16, 16)] = "InvisibleSlopeRight";
        ObjectLookup[new KnyttPoint(16, 17)] = "Barrier";
        ObjectLookup[new KnyttPoint(16, 19)] = "AdditionalBarrier19";
        ObjectLookup[new KnyttPoint(16, 20)] = "AdditionalBarrier20";
        ObjectLookup[new KnyttPoint(16, 21)] = "AdditionalSlope21";
        ObjectLookup[new KnyttPoint(16, 22)] = "AdditionalSlope22";
        ObjectLookup[new KnyttPoint(16, 23)] = "AdditionalSlope23";
        ObjectLookup[new KnyttPoint(16, 24)] = "AdditionalSlope24";
        ObjectLookup[new KnyttPoint(16, 25)] = "AdditionalBarrier25";
        ObjectLookup[new KnyttPoint(16, 26)] = "AdditionalBarrier26";
        ObjectLookup[new KnyttPoint(16, 27)] = "AdditionalBarrier27";
        ObjectLookup[new KnyttPoint(16, 28)] = "AdditionalBarrier28";
        ObjectLookup[new KnyttPoint(16, 29)] = "OneWayPlatform";
        ObjectLookup[new KnyttPoint(16, 30)] = "TwoWayPlatform";
        ObjectLookup[new KnyttPoint(17, 1)] =  "DarkRandomizer";
        ObjectLookup[new KnyttPoint(17, 2)] =  "SmallSpider";
        ObjectLookup[new KnyttPoint(17, 3)] =  "WaterEye";
        ObjectLookup[new KnyttPoint(17, 4)] =  "MadSpider";
        ObjectLookup[new KnyttPoint(17, 5)] =  "CeilingMadSpider";
        ObjectLookup[new KnyttPoint(17, 7)] =  "Ninja";
        ObjectLookup[new KnyttPoint(17, 8)] =  "RightNinja";
        ObjectLookup[new KnyttPoint(17, 9)] =  "LeftNinja";
        ObjectLookup[new KnyttPoint(17, 10)] = "FloorSpiker";
        ObjectLookup[new KnyttPoint(17, 11)] = "LeftSpiker";
        ObjectLookup[new KnyttPoint(17, 12)] = "RightSpiker";
        ObjectLookup[new KnyttPoint(18, 1)] =  "Fish";
        ObjectLookup[new KnyttPoint(18, 2)] =  "Fish";
        ObjectLookup[new KnyttPoint(18, 3)] =  "Fish";
        ObjectLookup[new KnyttPoint(18, 4)] =  "Fish";
        ObjectLookup[new KnyttPoint(18, 5)] =  "Fish";
        ObjectLookup[new KnyttPoint(18, 6)] =  "WaterMonsterNew";

        ObjectLookup[new KnyttPoint(19, 7)] = "Collectable7";
        ObjectLookup[new KnyttPoint(19, 9)] = "Collectable9";
        for (int i = 11; i <= 50; i++)
        {
            ObjectLookup[new KnyttPoint(19, i)] = $"Collectable{i}";
        }

        for (int i = 51; i <= 150; i++)
        {
            ObjectLookup[new KnyttPoint(19, i)] = "Coin";
        }
        for (int i = 151; i <= 199; i++)
        {
            ObjectLookup[new KnyttPoint(19, i)] = "Artifact";
        }
        for (int i = 1; i <= 255; i++)
        {
            ObjectLookup[new KnyttPoint(255, i)] = "CustomObject";
        }
    }

    public static GDKnyttObjectBundle buildKnyttObject(KnyttPoint object_id)
    {
        if (!ObjectLookup.ContainsKey(object_id))
        {
            GD.Print($"Object {object_id.x}:{object_id.y} unimplemented.");
            return null;
        }
        
        string fname = $"res://knytt/objects/banks/bank{object_id.x}/{ObjectLookup[object_id]}.tscn";
        var scene = ResourceLoader.Load<PackedScene>(fname);
        return new GDKnyttObjectBundle(object_id, scene);
    }
}

public class GDKnyttObjectBundle
{
    public KnyttPoint object_id;
    PackedScene scene;
    public Texture icon;

    public GDKnyttObjectBundle(KnyttPoint object_id, PackedScene scene, Texture icon=null)
    {
        this.object_id = object_id;
        this.scene = scene;
        this.icon = icon;
    }
    
    public GDKnyttBaseObject getNode(GDKnyttObjectLayer layer, KnyttPoint coords)
    {
        var node = scene.Instance() as GDKnyttBaseObject;
        node.initialize(object_id, layer, coords);
        return node;
    }
}
