path = './output copy.txt'
text = ''

with open(path) as f:
    lines = [l.title().replace('_', '') for l in f.readlines()]
    lines.sort(key=lambda l: len(l))
    text = ''.join(lines)

open('./pascal output.txt', 'w').write(text)
