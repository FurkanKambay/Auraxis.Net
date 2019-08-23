import re
import requests
import time

collections = ['single_character_by_id','character','character_name','characters_achievement','characters_currency','characters_directive','characters_directive_objective','characters_directive_tier','characters_directive_tree','characters_skill','characters_stat','characters_stat_by_faction','characters_stat_history','characters_weapon_stat','characters_weapon_stat_by_faction','world_stat_history','characters_item','ability','ability_type','achievement','armor_facing','armor_info','currency','directive','directive_tier','directive_tree','directive_tree_category','effect','effect_type','empire_scores','experience','experience_rank','facility_link','facility_type','faction','fire_group','fire_group_to_fire_mode','fire_mode','fire_mode_2','fire_mode_to_projectile','fire_mode_type','image','image_set','image_set_default','item','item_attachment','item_category','item_profile','item_to_weapon','item_type','loadout','map_hex','map_region','marketing_bundle','marketing_bundle_item','marketing_bundle_with_1_item','metagame_event','metagame_event_state','objective','objective_set_to_objective','objective_type','player_state','player_state_group','player_state_group_2','profile','profile_2','profile_armor_map','profile_resist_map','projectile','projectile_flight_type','region','resist_info','resist_type','resource_type','reward','reward_group_to_reward','reward_set_to_reward_group','reward_type','skill','skill_category','skill_line','skill_set','target_type','title','vehicle','vehicle_attachment','vehicle_faction','vehicle_skill_set','weapon','weapon_ammo_slot','weapon_datasheet','weapon_to_attachment','weapon_to_fire_group','zone','zone_effect','zone_effect_type','characters_world','world','outfit','outfit_member','outfit_member_extended','outfit_rank','characters_online_status','map','characters_friend','leaderboard','characters_leaderboard','characters_event_grouped','characters_event','event','world_event']
noData = []
messages = []

for c in collections:
  url = f'http://census.daybreakgames.com/get/ps2/{c}?error=1'
  s = 'Missing Service ID'
 
  while 'Missing Service ID' in s:
    time.sleep(20)
    print(f'{time.ctime()}: {url}')
    s = requests.get(url).text
  else:
    if 'INVALID_SEARCH_TERM' in s:
      msg = re.search(r'\[.+]', s).group(0)
      messages.append(f'{c}: {msg}')
    else:
      noData.append(url)
