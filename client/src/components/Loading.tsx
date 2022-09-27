import { Spin } from "antd"

const Loading = () => {
    return (
        <div className="Loading">
            <Spin size="large"  tip="loading... "/>
        </div>
    )
}

export default Loading;