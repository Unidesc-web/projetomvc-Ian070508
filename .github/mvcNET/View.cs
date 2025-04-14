using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
// Exemplo Copilot

@model List<ConcessionariaApp.Models.Carro>

<h1>Carro List</h1>
<table>
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Price</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var Carro in Model)
        {
            <tr>
                <td>@carro.Id</td>
                <td>@carro.Name</td>
                <td>carro.Price.ToString("C")</td>
                <td>
                    <a asp-action="Details" asp-route-id="@Carro.Id">Details</a>
                </td>
            </tr>
        }
    </tbody>
</table>
<a asp-action="Create">Add New Carro</a>