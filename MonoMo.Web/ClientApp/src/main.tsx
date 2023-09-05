import React from 'react'
import ReactDOM from 'react-dom/client'

import {BrowserRouter} from "react-router-dom";
import {Block} from "./components/Block";

ReactDOM.createRoot(document.getElementById('root')!).render(
    <React.StrictMode>
        <BrowserRouter>
            <Block/>
        </BrowserRouter>
    </React.StrictMode>
)
