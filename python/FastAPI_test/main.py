import asyncio
from fastapi import FastAPI
from fastapi.responses import HTMLResponse, StreamingResponse

app = FastAPI()


# HTTPストリーミングレスポンスを返す
@app.get("/streaming")
async def streaming():
    text = '''吾輩は猫である。名前はまだ無い。どこで生れたかとんと見当けんとうがつかぬ。
何でも薄暗いじめじめした所でニャーニャー泣いていた事だけは記憶している。
吾輩はここで始めて人間というものを見た。しかもあとで聞くとそれは書生という人間中で一番獰悪どうあくな種族であったそうだ。
この書生というのは時々我々を捕つかまえて煮にて食うという話である。
'''
    async def generate_data():
        for c in text:
            yield c
            await asyncio.sleep(0.05)

    return StreamingResponse(generate_data(), media_type="text/plain")


# HTMLを返す
@app.get("/")
async def index():
    html = '''
<html>
    <body>
        <h1>Hello Streaming!</h1>
        <div id="foo" style="white-space: pre-wrap;"></div>

        <script>
        document.addEventListener('DOMContentLoaded', async function () {
            const div = document.getElementById("foo");
            const response = await fetch("/streaming", {method: "GET"});
            if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
            }
            const decoder = new TextDecoder();
            const reader = response.body.getReader();
            while (true) {
                const { done, value } = await reader.read();
                if (done) break;
                const text = decoder.decode(value);
                div.textContent = div.textContent + text;
            }
        });
        </script>
    </body>
</html>
'''
    return HTMLResponse(content=html)
