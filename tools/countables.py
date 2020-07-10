import re
from os import listdir
from os.path import isfile, join

path = r'D:/Source/FurkanKambay/Auraxis.Net/src/Auraxis.Net/Collections'
files = [f.replace('.cs', '') for f in listdir(path) if isfile(join(path, f))]

_non_countable_names = ['map', 'characters_world', 'characters_online_status', 'characters_friend',
                        'leaderboard', 'characters_leaderboard', 'event', 'characters_event_grouped', 'single_character_by_id']
non_countable_names = [x.title().replace('_', '')
                       for x in _non_countable_names]

countable_files = [f for f in files if f not in non_countable_names]
non_countable_files = [f for f in files if f in non_countable_names]

for fp in files:
    filepath = join(path, f'{fp}.cs')
    lines = []
    to_append = ''

    with open(filepath) as f:
        lines = f.readlines()
        (index, derived) = [(lines.index(l), ':' in l)
                            for l in lines if 'public class' in l][0]

        text = 'ICountableCollection' if fp in countable_files else 'ICollection'
        prefix = ', ' if derived else ' : '
        to_append = prefix + text
        lines[index] = lines[index].replace('\n', prefix + text + '\n')

    open(filepath, 'w').writelines(lines)

    # new_text = re.sub(r'public class (.+)( : \w+)?',
    #                   r'public class \1\2', content)

    # line_index = content.find(f'public class {fp}')
    # index = content.find('\n', line_index)

    # f.seek(index-1)
    # print(f'Appending "{prefix + text}" to file {fp}.cs at index {index-1}')
    # f.write(prefix + text)
