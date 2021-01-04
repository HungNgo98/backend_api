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

Route::middleware('auth:api')->get('/user', function (Request $request) {
    return $request->user();
});

Route::get('getall',[App\Http\Controllers\UserController::class,'getAllUser']);
Route::post('create',[App\Http\Controllers\UserController::class,'createUser']);
Route::post('update',[App\Http\Controllers\UserController::class,'updateUser']);
Route::delete('delete',[App\Http\Controllers\UserController::class,'deleteUser']);
//Route::get('categories', 'apiCategoryController@getAllCategories');
//Route::get('categories/{id}', 'apiCategoryController@getCategories');
//Route::post('categories', 'apiCategoryController@createCategories');
//Route::put('categories/{id}', 'apiCategoryController@updateCategories');
//Route::delete('categories/{id}','apiCategoryController@deleteCategories');
Route::prefix('Category')->group(function () {
    Route::get('getall', [App\Http\Controllers\CategoryController::class, 'getAllCategories']);
    Route::get('create', [\App\Http\Controllers\CategoryController::class, 'getAllCategories']);
    Route::post('update', [\App\Http\Controllers\CategoryController::class, 'getCategories']);
    Route::delete('delete', [\App\Http\Controllers\CategoryController::class, 'getAllCategories']);
});

Route::prefix('product')->group(function () {
    Route::get('list', [\App\Http\Controllers\ProductController::class, 'getAllProducts']);
    Route::post('create', [\App\Http\Controllers\ProductController::class, 'createProducts']);
    Route::post('update/{id}', [\App\Http\Controllers\ProductController::class, 'updateProducts']);
    Route::delete('delete/{id}', [\App\Http\Controllers\ProductController::class, 'deleteProducts']);
});
