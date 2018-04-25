﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeRoutine.Routine.BuildYourOwnRoutine.UI
{
    public enum BuffEnums
    {
        ignited,
        chilled,
        frozen,
        shocked,
        sprinting,
        flask_effect_life,
        grace_period,
        flask_effect_mana,
        poison,
        blood_rage,
        righteous_fire,
        righteous_fire_aura,
        demon_righteous_fire,
        demon_righteous_fire_aura,
        avatar_righteous_fire,
        avatar_righteous_fire_aura,
        invisible_fire_aura,
        invisible_fire_debuff,
        invisible_holy_fire_debuff,
        invisible_holy_fire_elder_debuff,
        invisible_kitava_fire_debuff,
        ion_beam_debuff,
        frost_ion_beam_debuff,
        fire_weapon,
        frenzy_charge,
        endurance_charge,
        power_charge,
        spirit_charge,
        siphoning_charge,
        void_arrow,
        hillock_buff,
        mana_leech,
        life_leech,
        energy_shield_leech,
        players_increased,
        flask_bonus_armour,
        flask_bonus_evasion,
        flask_bonus_energy_shield,
        flask_bonus_movement_speed,
        flask_bonus_stun_recovery,
        flask_bonus_resistances,
        flask_bonus_life_leech,
        flask_bonus_mana_leech,
        flask_bonus_knockback,
        flask_bonus_global_knockback,
        flask_bonus_prevents_death,
        flask_bonus_chill_and_freeze_immunity,
        flask_bonus_ignite_immunity,
        flask_bonus_shock_immunity,
        flask_bonus_bleeding_immunity,
        flask_bonus_curse_immunity,
        spectre_buff,
        infernal_blow_hit,
        viper_strike_orb,
        phase_run,
        monster_magic_effect_buff,
        monster_rare_effect_buff,
        fuse_arrow_orb,
        curse_temporal_chains,
        curse_elemental_weakness,
        curse_fire_weakness,
        curse_cold_weakness,
        curse_lightning_weakness,
        curse_warlords_mark,
        curse_punishment,
        curse_enfeeble,
        curse_assassins_mark,
        curse_projectile_weakness,
        curse_vulnerability,
        curse_poachers_mark,
        curse_newpunishment,
        monster_aura_physical_thorns,
        monster_aura_elemental_thorns,
        monster_physical_thorns,
        monster_elemental_thorns,
        monster_aura_medium_physical_damage,
        monster_aura_large_physical_damage,
        monster_aura_speed,
        monster_aura_life_regen,
        monster_aura_resists,
        monster_aura_energy_shield,
        monster_aura_energy_shield_bubble,
        monster_aura_accuracy_and_crits,
        monster_aura_pus_puke_degen,
        monster_aura_chaos_degen,
        monster_aura_physical_degen,
        monster_aura_lightning_degen,
        monster_aura_elemental_damage,
        monster_aura_essence_daemon_degen,
        monster_thorns_physical,
        monster_thorns_elemental,
        monster_thorns_physical_large,
        monster_thorns_elemental_large,
        monster_thorns_bloodline,
        monster_thorns_bloodline_large_model,
        dominated,
        dominating_blow_hit_buff,
        immortal_call,
        vaal_immortal_call,
        lightning_shield,
        fire_shield,
        flask_utility_critical_strike_chance,
        flask_utility_resist_fire,
        flask_utility_resist_cold,
        flask_utility_resist_lightning,
        flask_utility_ironskin,
        flask_utility_sprint,
        flask_utility_resist_chaos,
        flask_utility_phase,
        flask_utility_evasion,
        flask_utility_stone,
        flask_utility_aquamarine,
        flask_utility_prismatic,
        flask_utility_smoke,
        flask_utility_consecrate,
        flask_utility_haste,
        elemental_equilibrium_buff,
        block_test,
        bleeding,
        bleeding_moving,
        player_aura_armour,
        player_aura_evasion,
        player_aura_resists,
        player_aura_fire_resist,
        player_aura_cold_resist,
        player_aura_lightning_resist,
        player_aura_energy_shield,
        player_aura_fire_damage,
        player_aura_cold_damage,
        player_aura_lightning_damage,
        player_aura_speed,
        player_aura_life_regen,
        power_shot_hit,
        player_aura_mana_regen,
        vaal_aura_armour,
        vaal_aura_life_regen,
        vaal_aura_no_mana_cost,
        vaal_aura_dodge,
        vaal_aura_energy_shield,
        vaal_aura_speed,
        beartrap_debuff,
        trap_convert_buff,
        ground_fire_burn,
        ground_ice_chill,
        ground_tar_slow,
        monster_no_drops_buff,
        totem_aura_life_regen,
        totem_aura_life_mana_regen,
        blinded,
        ice_shield,
        ice_shield_moving,
        frozen_damage_increase,
        lightning_thorns,
        piety_fire_form,
        piety_ice_form,
        leaving_area_protection,
        vinktar_lightning_bond_in_beam,
        searing_bond_in_beam,
        ground_desecration,
        ground_consecration,
        unique_flask_ghost_reaver,
        unique_flask_zealots_oath,
        unique_flask_zerphis_last_breath,
        flask_immune_to_damage,
        unique_flask_divination_distillate,
        onslaught,
        undying_rage,
        unique_deaths_oath_aura,
        unique_deaths_oath_debuff,
        birdman_consume_corpse_buff,
        damage_aura,
        reave_counter,
        chilling_bond_in_beam,
        additional_totems_test,
        dominus_mark,
        manashield,
        proximity_shield_aura,
        incinerate_counter,
        chilled_burn_damage_increase,
        ground_lightning_shock,
        ground_smoke_blind,
        smoke_mine_movement_speed,
        trapdamage,
        unique_flask_tears_of_the_dybbuk_prince,
        movement_speed_buff,
        proximity_shield_buff,
        freeze_mine_cold_resistsance_debuff,
        corrupted_blood,
        corrupted_blood_rain,
        shrine_acceleration,
        shrine_brutal,
        shrine_thorns,
        shrine_regen,
        shrine_critical,
        shrine_fire,
        shrine_lightning,
        shrine_cold,
        shrine_arc,
        shrine_smoke,
        shrine_skeleton,
        shrine_echoing,
        shrine_curses,
        shrine_massive,
        shrine_defence,
        shrine_godmode,
        shrine_resistance,
        farshot,
        mine_trap_test,
        animated_armour,
        unique_flask_blood_of_the_karui,
        unique_flask_laviangas_cup,
        oba_death_buff,
        nemesis_transformed,
        curse_silence,
        curse_aura_silence,
        soul_eater_aura,
        soul_eater,
        nemesis_stealth_mode,
        seawitch_lightning_beam,
        usemax_life_regen,
        statusailmenttest,
        vortex_mine,
        charged_blast_counter,
        chill_prevention,
        freeze_prevention,
        ignite_prevention,
        shock_prevention,
        unique_dying_breath_curse_aura,
        unique_dying_breath_damage_aura,
        int_mission_dying_breath_aura,
        sea_witch_screech_debuff,
        offering_offensive,
        offering_defensive,
        unholy_might,
        unholy_might_permanent,
        unholy_might_from_flask,
        daemon_delay,
        fire_enrage,
        atziri_fire_charge,
        atziri_lightning_charge,
        atziri_physical_charge,
        unique_flask_atziris_promise,
        kiweth_enrage,
        pinned,
        vaal_cloud_stack,
        vaal_cloud,
        cannot_die,
        atziri_charge_requirement_reduction,
        status_immunity_enrage,
        upheavalbuff,
        unique_flask_forbidden_taste,
        darkexile_corruption,
        darkseawitch_corruption,
        rampage_stack,
        unique_flask_rumis_concoction,
        marauder_mission_have_idol,
        cagan_darkness,
        physical_immunity,
        bleeding_movespeed_penalty,
        mission_relic_grace,
        mission_duelist_grace,
        hound_effect_buff,
        exile_arcane_buff,
        oba_decapitated,
        heal,
        herald_of_ash,
        herald_of_ice,
        herald_of_thunder,
        herald_of_thunder_active,
        cannot_be_damaged,
        mission_relic_praying,
        mission_beast_corrupted,
        mission_monster_target,
        stun_display_buff,
        visual_display_buff,
        visual_display_buff_gargoyle,
        mission_int_buff,
        fire_damage_and_ignite,
        cold_damage_and_freeze,
        lightning_damage_and_shock,
        strdex_mission_fire_damage,
        strdex_mission_cold_damage,
        strdex_mission_lightning_damage,
        physical_damage_and_bleed,
        monster_life_flask,
        union_of_souls,
        bloodlines_shrouded,
        bloodlines_necrovigil,
        bloodlines_damage_charge,
        bloodlines_speed_charge,
        cold_thorns,
        monster_bloodlines_damage_reduction,
        unique_flask_taste_of_hate,
        damage_aura_skeleton_elite,
        trap_nonplayer_immunity,
        inspiring_cry,
        kaom_archer_effect,
        lb_kaom_archer_effect,
        abyssal_cry,
        unique_shapers_seed_regeneration,
        vaal_aura_elemental_damage_healing,
        fortify,
        taunted,
        blackguardzombie_speedbuff,
        kaom_fire,
        taunt_immunity,
        stacking_ignite,
        stolen_mod_buff,
        ice_elemental_buff,
        fire_elemental_buff,
        chaos_elemental_buff,
        lightning_elemental_buff,
        culling_strike_aura,
        increased_item_rarity_aura,
        piety_fire_form_stacking_damage_taken,
        enduring_cry_life_regeneration,
        flame_golem_effects,
        flame_golem_summoned_effects,
        flame_golem_runic_effects,
        new_punishment_buff,
        totem_placement_buff,
        new_arctic_armour,
        new_arctic_armour_stationary,
        unique_flask_lions_roar,
        revenant_revive_possessed,
        revenant_revive_explode,
        unique_flask_chaos_damage_damages_es,
        unique_flask_es_regen,
        blood_rage_xandro,
        malachai_invulnerable,
        exploding_storm_buff,
        diamond_storm,
        uber_diamond_storm,
        replenishing_storm,
        echoing_storm,
        divine_storm,
        rarity_storm,
        uber_rarity_storm,
        massive_storm,
        tiny_storm,
        fire_damage_storm,
        cold_damage_storm,
        lightning_damage_storm,
        smoke_trail_storm,
        corpse_devour_storm,
        projectile_nova_storm,
        veil_storm,
        voltaxic_storm,
        phasing_storm,
        corrupted_drops_storm,
        drop_as_sell_price_storm,
        quality_drops_storm,
        identify_items_storm,
        arcane_storm,
        status_immunity_storm,
        ground_spore_damage,
        flask_bonus_item_rarity,
        map_boss_duet_enrage,
        ground_spores,
        new_phase_run,
        new_phase_run_damage,
        tempest_soul_eater,
        static_tether,
        flask_bonus_mana_regeneration_rate,
        flask_bonus_flask_charge_recovery,
        frost_bomb,
        lightning_bomb,
        borrowed_power_lightning_aura,
        sawblade_damage,
        usemax_mana_regen,
        righteous_lightning,
        righteous_lightning_aura,
        life_leech_damage,
        enchantment_added_fire_damage,
        enchantment_dodge_chance,
        talisman_monster,
        caustic_cloud,
        enchantment_reduced_mana_cost,
        enchantment_stun_avoid,
        enchantment_spell_dodge,
        enchantment_attack_and_cast_speed,
        enchantment_added_cold_damage,
        enchantment_life_and_mana_leech,
        enchantment_life_mana_regen,
        attack_speed_when_hit,
        berserker_life_and_mana_leech,
        added_fire_damage,
        attack_and_cast_speed,
        physical_damage_stacking,
        block_chance,
        damage,
        taunted_special,
        damage_and_movement_speed,
        scion_movement_speed,
        siphon_damage,
        contagion,
        hinder,
        wither_resistance,
        siphon_leech,
        rallying_cry_damage_added_as_mana,
        offering_of_judgement_fire,
        offering_of_judgement_chaos,
        offering_of_judgement_counter,
        her_blessing,
        maim,
        lightning_flask,
        lightning_flask_attack_damage,
        lightning_flask_spell_damage,
        lightning_flask_physical_to_lightning,
        lightning_flask_lightning_penetration,
        shock_aura,
        trap_pinned,
        stacking_increased_spell_damage,
        templar_ascendency_movement_speed,
        guardian_warcry,
        avoid_stun_staff_aura,
        flying_roomba_damage,
        offering_of_judgement_ground,
        curse_damage_taken,
        increased_crit_chance,
        increased_minion_damage,
        increased_damage,
        damage_taken,
        avoid_stun,
        spinning_blade_damage,
        stacking_movement_speed_buff,
        nightwane_effects,
        increased_elemental_damage_taken,
        mana_and_es_regeneration,
        vinktar_boss_buff,
        grant_es_to_nearby_allies,
        grant_armour_to_nearby_allies,
        singularity_aura,
        power_symbol_aura,
        gargoyle_statue_buff,
        vinktar_lightning_bond,
        killed_rare_monsters_drop_uniques,
        savage_hit_life_leech,
        savage_hit_damage,
        savage_hit_attack_cast_speed,
        savage_hit_attack_speed,
        melee_physical_damage,
        grasping_ornaments_slow_aura,
        grasping_tentacles_slow_aura,
        grasping_pincers_slow_aura,
        labyrinth_boss_grace,
        izaro_summon_lieutenant_delay,
        shield_defence_aura,
        labyrinth_trap_bleed,
        mine_detonation,
        augry_of_penitence,
        scion_augry_of_penitence,
        labyrinth_power_symbol_shield,
        awaken_gargoyle,
        spell_damage_increase,
        attack_damage_increase,
        attack_speed_increase,
        cast_speed_increase,
        life_es_and_mana_recovery,
        rock_golem_buff,
        talisman_totem_effects,
        spike_trap_immunity,
        labyrinth_arrow_slow,
        shrink,
        lightning_eye_effects,
        talisman_degen,
        blade_vortex_counter,
        soul_eater_from_stat_parent,
        LocustSwarmStackingDegenAuraFire,
        LocustSwarmStackingDegenAuraCold,
        LocustSwarmStackingDegenAuraLightning,
        rigwald_channeling,
        blade_vortex,
        elemental_overload,
        frost_nova_counter,
        heirophant_attack_and_spell_damage,
        heirophant_additional_totems,
        petrified,
        flask_petrification,
        blight,
        flask_bonus_poison_immunity,
        flask_bonus_physical_damage_reduction_percent,
        life_regen_from_spread_poison,
        elementalist_increased_fire_damage,
        elementalist_increased_lightning_damage,
        elementalist_increased_cold_damage,
        elementalist_increased_elemental_damage,
        elementalist_cold_penetration,
        elementalist_fire_penetration,
        elementalist_lightning_penetration,
        elemental_conflux,
        elementalist_increased_fire_damage_taken,
        elementalist_increased_lightning_damage_taken,
        elementalist_increased_cold_damage_taken,
        elementalist_increased_elemental_damage_cooldown,
        occultist_non_chaos_to_chaos_damage,
        occultist_nearby_enemies_chaos_resist_life_regen,
        occultist_no_energy_shield_recharge_delay,
        izaro_elemental_fire_buff_phase1,
        izaro_elemental_fire_buff,
        izaro_elemental_cold_buff_phase1,
        izaro_elemental_cold_buff,
        izaro_elemental_lightning_buff_phase1,
        izaro_elemental_lightning_buff,
        charged_attack,
        petrify_enrage,
        occultist_stacking_es_recovery_per_minute_percent,
        izaro_chronos_statue_damage_phase1,
        izaro_chronos_statue_damage,
        izaro_chronos_statue_speed_phase1,
        izaro_chronos_statue_speed,
        izaro_chronos_statue_damage_taken_phase1,
        izaro_chronos_statue_damage_taken,
        izaro_gargoyles_damage_buff_phase1,
        izaro_gargoyles_damage_buff,
        izaro_gargoyles_speed_buff_phase1,
        izaro_gargoyles_speed_buff,
        izaro_gargoyles_damage_taken_buff_phase1,
        izaro_gargoyles_damage_taken_buff,
        izaro_pedestals_physical_damage_reduction_buff_phase__1,
        izaro_pedestals_physical_damage_reduction_buff,
        izaro_pedestals_physical_damage_buff_phase__1,
        izaro_pedestals_physical_damage_buff,
        izaro_pedestals_additional_energy_shield_phase__1,
        izaro_pedestals_additional_energy_shield,
        izaro_charge,
        izaro_super_charge,
        offering_spirit,
        totem_aura_chieftain,
        guardian_share_charges_with_party_members_in_aura,
        guardian_conduit_aura_enemies,
        guardian_dispel_cooldown,
        guardian_life_regen,
        izaro_disrupter_inactive,
        izaro_buff_loot_bonus,
        melee_ancestor_totem_attack_speed,
        slash_ancestor_totem_phys_added_as_fire,
        slam_ancestor_totem_melee_damage,
        guardian_cannot_be_stunned_aura,
        izaro_pedestal_timer_buff,
        lightning_golem_wrath,
        chronos_statues_buff,
        damage_increase_when_killed_bleeding_enemy,
        damage_increase_when_killed_cursed_enemy,
        increased_minion_attack_and_cast_speed,
        increased_attack_and_cast_speed,
        curse_enemy_chaos_resistance,
        guardian_increased_attack_and_cast_speed,
        guardian_increased_damage,
        champion_aura_increased_damage_under_fortify,
        enrage_buff,
        elemental_penetration_from_mine_detonation,
        have_killed_recently,
        number_of_times_have_been_hit_recently,
        have_been_crit_recently,
        have_crit_recently,
        have_taken_attack_damage_recently,
        have_taken_spell_damage_recently,
        have_used_a_warcry_recently,
        have_been_savage_hit_recently,
        have_hit_an_enemy_recently,
        chronos_statue_life_regen,
        perandus_gold_spectre_buff,
        bane_of_the_loyal,
        heart_of_the_gargoyle,
        cube_of_absorption,
        orb_of_elemental_essence,
        rod_of_detonation,
        sand_of_eternity,
        cogs_of_disruption,
        portal_shredder,
        perandus_chest_revive_marker,
        active_offering,
        ground_maelstrom_chill,
        aura_increased_damage_taken,
        aura_damage_on_movement_skill_use,
        savage_hit_life_regen,
        overflowing_chalice,
        have_killed_a_taunted_enemy_recently,
        shavronne_torment_aura,
        flask_bonus_flask_charges_gained,
        goddess_slow,
        have_pierced_recently,
        goddess_beam,
        have_killed_a_maimed_enemy_recently,
        have_taunted_an_enemy_recently,
        guardian_additional_block_chance,
        guardian_block_cooldown,
        blocked_unique_enemy_hit_recently,
        elementalist_increased_area_of_effect,
        guardian_increased_elemental_resist,
        pale_court_invulnerability,
        pale_court_ghost_invulnerability,
        intimidated,
        number_of_corpses_consumed_recently,
        flask_cannot_be_stunned,
        ascendancy_life_leech,
        kiaras_determination,
        prophecy_stolen_mods_buff,
        summon_specific_monsters_cannot_die,
        phoenix_firebomb,
        repeated_pulse_cold,
        repeated_pulse_lightning,
        repeated_pulse_fire,
        repeated_pulse_chaos,
        essence_alternating_buffs_dodge_and_spell_dodge,
        essence_alternating_buffs_reduced_damage_taken,
        essence_alternating_buffs_always_crit,
        flask_elemental_penetration,
        essence_elemental_damage_taken,
        essence_burning_ground,
        essence_elemental_damage_taken_granted,
        curse_immunity,
        essence_base_buffs_move_atack_cast_speed,
        essence_base_buffs_damage,
        essence_base_buffs_crit_immune,
        permanent_debuff_on_minion_death,
        have_blocked_attack_recently,
        phoenix_stacking_debuff,
        fire_beam_damage_stacks,
        brain_scrambler_shock_effects,
        razor_unique_increased_burning_damage,
        shaper_immune,
        shaper_beam,
        decay,
        endurance_frenzy_charge_essence,
        remnant_of_corruption_aura,
        chieftain_enrage_aura,
        chieftain_enrage_buff,
        rhoa_map_boss_enrage_buff,
        monolith_monster_freedom,
        essence_random_charge,
        essence_charge_max_and_duration,
        minotaur_arctrap_debuff,
        new_blade_vortex,
        new_blade_vortex_effect,
        zana_immune_buff,
        aura_movement_speed_for_spiders,
        covered_in_spiders,
        remove_covered_in_spiders,
        restore,
        alternating_buffs_item_rarity,
        base_buffs_item_quantity,
        unique_flask_witchfire_brew,
        unique_flask_dying_sun,
        atlas_lightning_golem_buff,
        aura_atlas_gold_pile,
        hallowed_ground_boss_invulnerability,
        elementalist_all_damage_chills,
        elementalist_all_damage_shocks,
        elementalist_all_damage_ignites,
        elementalist_all_damage_chills_shocks_ignites,
        shaper_minions_buff,
        map_poisoned_while_moving,
        map_damage_taken_while_stationary,
        map_damage_taken,
        ground_haste,
        damage_taken_on_200_mana_spent,
        mass_summon_ravens,
        damage_and_damage_taken,
        map_damage_and_damage_taken_while_stationary,
        ground_tar_gold,
        strongbox_enrage,
        cover_in_ash,
        empowering_howl,
        new_new_blade_vortex,
        have_summoned_golem_in_past_8_seconds,
        golem_summoned_in_past_8_seconds,
        elementalist_shaper_of_desolation_cooldown,
        new_blight,
        monster_consume_charges,
        player_tencent_asset_lock_bonus,
        player_tencent_no_asset_lock,
        tencent_tas_lock,
        blizzard_enemy,
        blizzard_ally,
        monster_convert_on_death,
        breach_team_warp_buff,
        breach_discharge_aura,
        breach_discharge,
        have_dealt_non_crit_recently,
        have_frozen_enemy_recently,
        number_of_shocked_enemies_killed_recently,
        track_movement,
        envy_chaos_damage,
        fire_beam_max_damage_stacks,
        rhoa_enrage,
        fire_beam_resistance_stacks,
        abberaths_hooves_display_buff,
        spider_god_spiders,
        number_of_chests_opened_recently,
        have_shattered_recently,
        additional_ignite,
        unique_flask_the_basics,
        classic_prophecy_quantity,
        tukohama_shield,
        ground_tar_net,
        offering_blood,
        have_blocked_spell_recently,
        have_used_a_fire_skill_recently,
        brutus_empowered,
        unique_victarios_flight_movement_velocity,
        intimidated_aura,
        beyond_host,
        brine_king_tide,
        energy_shield_has_started_recharging_recently,
        ground_devouring_darkness,
        have_stopped_taking_damage_over_time_recently,
        have_been_frozen_recently,
        have_been_stunned_recently,
        tukohama_god_stationary_buff,
        ryslatha_god_life_flask_charges_gain,
        tangmazu_god_curses_have_no_effect_on_you_cooldown,
        curses_have_no_effect_on_you,
        infested,
        fearless,
        frog_orb_aura,
        frog_orb_aura_minions,
        water_orb_aura,
        stolen_mods_inspired_learning,
        stolen_mods_leaguestone,
        abberath_minion_buff,
        herald_of_ash_burning,
        number_of_enemies_shocked_recently,
        kitava_swipe_debuff,
        despair_bear_slow,
        have_used_movement_skill_recently,
        ascendant_chaos_resistance,
        ascendant_block_chance,
        ascendant_attack_cast_movement_speed,
        have_placed_trap_or_mine_recently,
        ground_despair_geyser,
        support_maimed_enemies_damage_taken,
        have_used_a_cold_skill_recently,
        attack_speed_debuff_from_hitting_enemy_recently,
        yugul_hidden_monster,
        ground_maelstrom_chill_lunaris,
        silver_orb_aggressive,
        ground_sandstorm,
        number_of_nearby_enemies,
        ralakesh_buff,
        plague,
        accelerate,
        arcane_surge,
        mana_gained_from_hit_damage,
        lightning_thorns_cold,
        blight_hinder_chaos_damage_taken,
        moontouched_buff,
        innervate_support,
        blackguardzombie_enrage,
        basilisk_slow,
        basilisk_gaze,
        bleeding_stack,
        ruthless_big_hit_counter,
        boulderdash_enrage,
        general_adus_supercharged,
        monster_temporary_additional_projectiles,
        intimidated_aura_rhoa,
        arcane_surge_mana_spent,
        darktongue_kiss,
        harbinger_minion_new,
        have_blocked_a_stun_recently,
        void_gaze,
        charged_dash_chance_to_dodge,
        kitava_heart_damage_taken,
        abyss_monsters_damage_taken,
        pantheon_brine_king_stun_immunity,
        power_charge_on_mana_spent,
        occultist_power_charge_on_mana_spent,
        caustic_cloud_trail,
        quicksand_aura,
        quicksand_buff,
        thaumaturgy_rotation,
        ankh_of_eternity_enrage,
        gain_random_charges_while_stationary,
        quicksand_display_buff,
        unique_flask_gorgon_poison,
        spectral_spinning_weapon,
        unique_flask_shakari_increased_speed,
        unique_flask_shakari_reduced_speed_per_second,
        have_been_damaged_by_hit_recently,
        have_used_a_minion_skill_recently,
        has_player_minion_been_killed_recently,
        minion_has_killed_enemy_recently,
        fire_impurity_buff,
        cold_impurity_buff,
        lightning_impurity_buff,
        storm_barrier_support,
        critical_strike_chance_on_mana_spent,
        critical_strike_chance_unique,
        her_embrace_unique,
        grasping_vines_aura,
        grasping_vines_buff,
        disable_light,
        tentacle_fiend_aura,
        tentacle_fiend_aura_monster,
        elder_siphon_debuff,
        elder_siphon_buff,
        elder_siphon_slow,
        elder_siphon_immobilise,
        ailments_types_grant_damage_taken_child_buff_shock,
        ailments_types_grant_damage_taken_child_buff_freeze,
        ailments_types_grant_damage_taken_child_buff_chill,
        ailments_types_grant_damage_taken_child_buff_ignite,
        ailments_types_grant_damage_taken_child_buff_bleeding,
        ailments_types_grant_damage_taken_child_buff_poison,
        stolen_mods_elder_stat,
        reduced_evasion_from_hit,
        iron_reflexes_every_16_sec,
        iron_reflexes_from_unique,
        have_stunned_an_enemy_recently,
        gain_endurance_charges_while_stationary,
        death_walk_display_buff,
        mother_of_flames_daemon_debuff,
        elemental_overload_every_16_sec,
        elemental_overload_from_unique,
        avatar_of_fire_every_8_sec,
        avatar_of_fire_from_unique,
        physical_reflect_mortar_mod,
        elemental_reflect_mortar_mod,
        disable_rarity_epk,
        curse_chaos_weakness,
        mirage_archer_visual_buff,
        shade_form,
        lich_crystal_damage_reduction,
        petrification_statue_gaze,
        elder_ground_spores,
        kitava_visual_display_buff,
        elder_tentacle_portal_no_revive,
        minions_no_drops_or_experience,
        zana_dont_hurt_me,
        skill_interruption,
        uber_elder_immune_buff,
        uber_shaper_immune_buff,
        total_mana_spent_recently,
        have_used_a_skill_recently,
        gain_void_arrows,
        temporal_anomaly,
        bestiary_monster_phase_in,
        intimidating_cry,
        cat_aspect,
        cats_stealth,
        cats_agility,
        bird_aspect,
        bird_aspect_double_damage,
        bird_aspect_movement_speed,
        spider_aspect,
        spider_aspect_webs,
        have_killed_cursed_enemy_recently,
        flask_life_gain_on_skill_use_over_4_seconds,
        crab_aspect,
        crab_aspect_stacking_buff,
        fire_projectile_retaliation,
        fire_projectile_retaliation_charging,
        physical_projectile_retaliation,
        physical_projectile_retaliation_charging,
        master_buff_treasure_hunter,
        godmode_ghost,
        best_crab_roar,
        vilenta_reflection_beam_degen,
        nemesis_vines,
        nemesis_vines_large,
        number_of_crab_charges_lost_recently,
        rage,
        bestiary_harpoon_slow,
        bestiary_tiger_teleport,
        bestiary_spider_web,
        lightning_clone_retaliation,
        lightning_clone_minion,
        elementalist_pendulum_rotation,
        elementalist_new_increased_elemental_damage,
        elementalist_new_increased_aoe,
        gain_endurance_charges_if_hit_recently,
        have_taken_fire_damage_from_a_hit_recently,
        chieftain_physical_as_fire_cycle,
        chieftain_physical_as_fire_for_3_sec,
        have_crit_in_past_8_seconds,
        number_of_traps_triggered_recently,
        number_of_mines_detonated_recently,
        additional_block_if_attacked_recently,
        additional_spell_block_if_have_cast_spell_recently,
        capture_monster_trapped,
        capture_monster_enraged,
        capture_monster_captured,
        capture_monster_disappearing,
        cold_beam_retaliation,
        juggernaut_phys_damage_prevented_as_life_regen,
        animated_guardian_defence_tracking,
        recent_rage_tracker,
        cannot_evade_attacks,
        adrenaline,
        malediction,
        spider_aspect_webs_resistance_and_damage,
        bestiary_boss_growing_damage_aoe,
        tailwind,
        tailwind_stacking_effectiveness,
        block_chance_per_hit_blocked_past_10_sec,
        blinding_aura,
        assassin_poison_duration,
        bestiary_cocoon,
        bestiary_spider_hallucinate,
        monster_menagerie_buff,
        bestiary_agile_rhex_alternator,
        bestiary_agile_rhex_aura1,
        bestiary_agile_rhex_aura2,
        bestiary_regen_ursa_alternator,
        bestiary_regen_ursa_aura1,
        bestiary_regen_ursa_aura2,
        bestiary_fast_lynx_alternator,
        bestiary_fast_lynx_aura1,
        bestiary_fast_lynx_aura2,
        bestiary_tank_crab_aura,
        bestiary_cold_squid_aura,
        bestiary_poison_spider_aura,
        bestiary_tiger_boss_aura1,
        elemental_warding_buff,
        bestiary_legendary_enrage,
        royale_pain
    }
}
