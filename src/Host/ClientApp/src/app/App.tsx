import * as React from 'react';
import { Route, Routes } from 'react-router';
import Layout from './Layout';
import Home from '../pages/Home';
import Counter from '../pages/Counter';
import FetchData from '../pages/FetchData';

import './custom.css'

export default () => (
    <Layout>
        <Routes>
            <Route path='/' element={<Home />} />
            <Route path='/counter' element={<Counter />} />
            <Route path='/fetch-data/:startDateIndex?' element={<FetchData />} />
        </Routes>
    </Layout>
);
