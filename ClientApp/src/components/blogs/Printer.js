import React from 'react'

const Printer = ({html}) => {
    return (
        <div style={{maxWidth: '100%', wordWrap: 'break-word'}} className="mt-5 position-relative text-center container" dangerouslySetInnerHTML={{__html: html}} />
    );
}

export default Printer;