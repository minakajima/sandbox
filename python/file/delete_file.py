import os

def delete_json_files(folder_path):
    for root, dirs, files in os.walk(folder_path):
        for file in files:
            if file.endswith(".json"):
                file_path = os.path.join(root, file)
                os.remove(file_path)

# Specify the folder path
folder_path = "C:/Data/output"

# Call the function to delete JSON files
delete_json_files(folder_path)