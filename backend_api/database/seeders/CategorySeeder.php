<?php

namespace Database\Seeders;

use Illuminate\Database\Seeder;

class CategorySeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        $faker = Factory::create('id');
        for ($i=0; $i < 10; $i++) {
            $data = [
                'name'     => $faker->name,
                'description'     => $faker->description,
                'created_at'=> $faker->dateTimeBetween('-2 month', '-1 days')->format('Y-m-d H:i:s'),
                'updated_at'=> $faker->dateTimeBetween('-2 month', '-1 days')->format('Y-m-d H:i:s')
            ];
            $this->db->table('categories')->insert($data);
        }
    }
}
