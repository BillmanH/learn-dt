import pandas as np
import altair as alt


def generate_twin(name,model_id):
    digital_twin_id = f'{name}-{str(uuid.uuid4())}'
    dt_json = {
        "$metadata": {
            "$model": model_id
        }
    }
    return digital_twin_id,dt_json

def updsert_twin()
    created_twin = service_client.upsert_digital_twin(digital_twin_id, dt_json)
    return created_twin