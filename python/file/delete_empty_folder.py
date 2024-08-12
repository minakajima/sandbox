import os

def delete_empty_folders(path):
    for root, dirs, files in os.walk(path, topdown=False):
        for dir in dirs:
            folder_path = os.path.join(root, dir)
            if not os.listdir(folder_path):
                os.rmdir(folder_path)

# Specify the path to delete empty folders
path = r'F:/Google フォト_out'

# Call the function to delete empty folders
delete_empty_folders(path)