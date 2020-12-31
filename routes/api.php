<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::middleware('auth:api')->get('/category', function (Request $request) {
    return $request->categories();
});
//Route::get('categories', 'apiCategoryController@getAllCategories');
//Route::get('categories/{id}', 'apiCategoryController@getCategories');
//Route::post('categories', 'apiCategoryController@createCategories');
//Route::put('categories/{id}', 'apiCategoryController@updateCategories');
//Route::delete('categories/{id}','apiCategoryController@deleteCategories');
Route::get('create', [\App\Http\Controllers\CategoryController::class, 'getAllCategories']);
Route::post('update', [\App\Http\Controllers\CategoryController::class, 'getCategories']);
Route::delete('delete', [\App\Http\Controllers\CategoryController::class, 'getAllCategories']);

