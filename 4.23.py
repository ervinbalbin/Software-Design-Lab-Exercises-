import os
def find(path, filename):
    total = os.path.getsize(path)
    if os.path.isdir(path):
        for filename in os.listdir(path):
            childpath = os.path.join(path, filename)
            total+= find(childpath)

    print('{0:<7}'.format(total), path)


