import re
from typing import List, NamedTuple, Optional, Tuple

Field = NamedTuple('Field', [('name', str), ('field_type', str)])
Collection = NamedTuple('Collection', [('name', str), ('name_pascal', str), ('fields', List[Field])])

text = open('pascal output.txt').read()

outputPattern = r'(.+): \[(.+)\]'
attributePattern = r'\[Json\(.+\]'

propsMap = dict(re.findall(outputPattern, text))
countMap = {k: len(v.split(', ')) for k, v in propsMap.items()}

incorrectFiles = []

for c in countMap.keys():
    path = f'../src/Auraxis.Net/Collections/{c}.cs'
    try:
        lines = open(path).readlines()
        result = [re.search(attributePattern, l) for l in lines]
        propertyCount = len([r for r in result if r])
        correctCount = countMap[c]

        if correctCount != propertyCount:
            print(f'{c.rjust(30)} - correct: {correctCount}, but: {propertyCount}')
            incorrectFiles.append(c)

    except FileNotFoundError:
        pass

final = [(f, propsMap[f]) for f in incorrectFiles]
