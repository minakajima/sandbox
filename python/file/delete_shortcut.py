import os

def delete_shortcuts(folder_path):
    for root, dirs, files in os.walk(folder_path):
        for file in files:
            if file.lower().endswith('.lnk'):
                file_path = os.path.join(root, file)
                os.remove(file_path)
                print(f"Deleted shortcut: {file_path}")

# Specify the folder path where you want to delete the shortcuts
folder_path = r'F:/Google フォト_out'

# Call the function to delete the shortcuts
delete_shortcuts(folder_path)