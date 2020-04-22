import React from 'react'

const Printer = ({html}) => {
    return (
        <div style={{maxWidth: '100%', wordWrap: 'break-word'}} dangerouslySetInnerHTML={{__html: html}} />
    );
}

export default Printer;