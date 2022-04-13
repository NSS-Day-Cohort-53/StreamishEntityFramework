import React from "react";
import { useState } from "react";

export const NavBar = () => {
    const [search, setSearch] = useState("")





    return (
        <div>
            <button>Search</button>
            <input onChange={(e) => setSearch(e.target.value)} />
        </div>
    )

}