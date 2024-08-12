import zipfile
import os

def unzip_files(start_index, end_index, output_directory):
    # 出力ディレクトリが存在しない場合は作成
    if not os.path.exists(output_directory):
        os.makedirs(output_directory)

    for i in range(start_index, end_index + 1):
        zip_file_name = f'takeout-20240810T125200Z-{i:03}.zip'
        zip_file_path = f'C:/Data/googleフォト/{zip_file_name}'
        try:
            with zipfile.ZipFile(zip_file_path, 'r') as zip_ref:
                zip_ref.extractall(output_directory)
                print(f'{zip_file_name} を {output_directory} に解凍しました。')
        except FileNotFoundError:
            print(f'ファイルが見つかりません: {zip_file_path}')
        except zipfile.BadZipFile:
            print(f'不正なZIPファイルです: {zip_file_path}')
        except Exception as e:
            print(f'エラーが発生しました: {e}')

# 使用例
start_index = 1
end_index = 57
output_directory = r'C:/Data/googleフォト/output'  # 生の文字列リテラルを使用
unzip_files(start_index, end_index, output_directory)