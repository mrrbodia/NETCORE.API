//class CommentBox extends React.Component {
//    render() {
//        return React.createElement(
//            'div',
//            { className: 'commentBox' },
//            'Hello, world! I am a CommentBox.',
//        );
//    }
//}

//ReactDOM.render(
//    React.createElement(CommentBox, null),
//    document.getElementById('content'),
//);

class Cities extends React.Component {

    constructor(props) {
        super(props);
    }

    loadCommentsFromServer() {
        const xhr = new XMLHttpRequest();
        xhr.open('get', this.props.url, true);
        xhr.onload = () => {
            const data = JSON.parse(xhr.responseText);
            this.setState({ data: data });
        };
        xhr.send();
    }

    componentDidMount() {
        this.loadCommentsFromServer();
    }

    render() {
        return (
            <div className="city">
                <h1>City</h1>
                <div></div>
            </div>
        );
    }
}

ReactDOM.render(
    <Cities url="/api/cities" />,
    document.getElementById('content')
);