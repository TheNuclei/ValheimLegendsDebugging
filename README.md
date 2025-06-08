Adds selectable hero classes to the game, each with 3 unique abilities. Cut through scores of enemies with a berserker's rage, stalk your prey as a swift shadow, or call down heavens fury in a storm of meteors - become a Legend!

Usage:
Extract dll and VLAssets folder into the BepInEx Plugins folder
Start game to generate a cfg file in the BepInEx conig folder
Edit hotkey bindings and other options in the ValheimLegends.cfg file
To select a class in-game, you need to add one of the following items to the access panel and sacrifice it on the altar to get the character class: 4.1 Class selection can be controlled through configuration options

** Select the class you wish top play by offering an item at the Eikthyr Altar ** Berserker - Bone fragments Druid - Dandelion Duelist - Thistle Enchanter - Resin Mage - Coal Metavoker - Raspberry Monk - Wood Priest - Stone Ranger - Boar Meat Rogue - Honey Shaman - Greydwarf Eye Valkyrie - Flint

See https://www.nexusmods.com/valheim/mods/796 for more details.



This is a fork of Visteus's fork. Big thanks to him for making the mod work in ashlands!

This fork fixes the Ranger's run stamina costs and move-speed on dodge-roll, and the Enchanter's Zone Buff spell failing to cast and becoming unusable until game restart.

Additionally I've rebalanced the skill XP gains. Some of the classes it would take nearly 200 hours of pushing the spell on cooldown to reach level 75 even.

The class skill gains have been rebalanced in the following manner:

If a class specializes in a single skill (all abilities based on it), it will reach 50/75/100 skill after 5/13/26 hours of active use (using on cooldown, every cooldown).
Classes that have a main skill and a sub skill (2 abilities use one skill, 1 ability uses another), it will reach 50/75/100 in 8/20/40 hours with the main skill, and 15/40/80 with the sub skill.
Classes that do not have a focus and have 3 different skills for their abilities will level them to 50/75/100 in 14/40/80 hours for all three.

This standardization should make it way easier to not accelerate some classes skill gains into the sun with the config's universal skillgain XP increase option, or make some classes into unmoving laggards when lowering the skill xp rate.
