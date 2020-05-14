using Godot;
using System;

namespace HP_Unlimited.Scenes
{
    public class CityScene : Node2D
    {
        // City:
        // City attracts heroes, maybe level plus 5, unlimited stream of heroes
        // Short wait timer between heroes? Try to spawn every 5 seconds if not at maximum?
        // All experience accumulated in shops/farms is your city's current experience.
        // Experience needed to level up city is 1,000x current level. Level 1 needs 1,000 to go to level 2.
        // Leveling up your city unlocks new buildings.
        // Leveling up your buildings unlock new items in those buildings.
        // Start with only melee weapon shop, monster farm, and one dungeon.

        // Heroes:
        // Heroes spawn with a given class, level, RNG experience, and equipment.
        // Heroes should spawn between city level / 2 and city level, minimum level 1.
        // Heroes have desired items (want list) to purchase as soon as they spawn.
        // Heroes are of a specific class, and can only purchase class-specific weapons/armor.
        // Heroes have a certain level, and can't purchase items above their level.
        // Heroes can want food, drinks, potions, weapons, armor, and to battle.
        // Heroes enter shops and spend 1-5 seconds looking for their wanted items, and purchase or leave.
        // If heroes can't find wanted item in shop, that want gets pushed to the end of their want list.
        // Item can only be pushed to the end of their list once; after that, it is deleted.

        // Battling:
        // Heroes battle enemies in dungeons, gain experience based on enemy level, might level up.
        // Heroes may need to rest or heal after a battle.
        // Heroes have 20% chance to want to battle again after resting/healing.
        // Heroes can't die during battle.
        // If hero has a health potion, they use it to heal at 25% health. They flee at 10% health.
        // If fleeing, hero will definitely rest/heal. 20% chance to try again.

        // Shops:
        // Armor, Weapon, Potion, Magic, Inn, Temple, Reward.
        // Shops gain experience based on items sold, up to level 50, maybe.
        // Experience required to level up shops is 100x current level. Level 1 needs 100 to go to level 2.
        // Every 5 levels, shops unlock (2/5?) extra slots to fill. Start with 5 open slots per building.
        // Items sold at shops increase shop experience. Item level * 5 is EXP earned.
        // Items take time to create.
        // Item maximum level is shop level * 2.
        // Items created have 2-5% chance to be special variants that sell at 5-10x cost, gives double building EXP.
        // Regular items are 2-4x cost.

        // Monster farms:
        // Monster farms create monsters.
        // Same idea as shops - experience is granted on heroes killing monsters.
        // Different types of monsters at different farms.

        // Dungeons:
        // Monsters are created at monster farms and added to dungeons.
        // Rewards are created at reward shop and added to dungeons.
        // Heroes enter dungeons to battle.
        // Monsters and heroes battle. If hero defeats monster, hero gets reward.

        // Various future ideas:
        // Bounty - Attract extra heroes to kill specific monsters. Cooldown timer. Bonus EXP and gold to city.
        // Tame monsters - Mini-game where you capture new types of monsters to build.

        // Called when the node enters the scene tree for the first time.
        public override void _Ready()
        {
        }

        //  // Called every frame. 'delta' is the elapsed time since the previous frame.
        //  public override void _Process(float delta)
        //  {
        //
        //  }
    }
}
